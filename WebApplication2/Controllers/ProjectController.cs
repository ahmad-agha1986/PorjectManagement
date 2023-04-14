using MailKit.Search;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProjectController : Controller
    {

        private readonly MyDatabaseContext _context;

        public ProjectController(MyDatabaseContext context)
        {
            _context = context;
        }



        //public IActionResult GetAllProjects()
        //{
        //    var projects = _context.Projects.Select(p => new Project1 { Project_Id = p.Project_Id, Name = p.Name, DueDate = p.DueDate, StartDate = p.StartDate }).ToList();

        //    return View(projects);
        //}

        public IActionResult GetAllProjects(int page = 1, int pageSize = 10, string searchTerm = "")
        {
        
            var projects = _context.Projects
                .Select(p => new Project1 { Project_Id = p.Project_Id, Name = p.Name, DueDate = p.DueDate, StartDate = p.StartDate })
            .ToList();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                projects = projects.Where(t =>
                    t.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    t.Project_Id.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Calculate the total number of projects and the number of pages
            int totalCount = projects.Count();
            int totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            
            int skip = (page - 1) * pageSize;
            var projectsToShow = projects.Skip(skip).Take(pageSize).ToList();

            var viewModel = new PaginationViewModel<Project1>
            {
                Items = projectsToShow,
                PageIndex = page,
                TotalPages = totalPages
            };

           
            ViewBag.HasPreviousPage = (page > 1);
            ViewBag.HasNextPage = (page < totalPages);

            return View(viewModel);
        }



        public IActionResult CreateProject()
        {
            ViewBag.Clients = new SelectList(_context.Clients, "Client_Id", "Email");
            return View();

        }

        [HttpPost]

        public async Task<IActionResult> Create([Bind("Name,DueDate,StartDate,Status,Client_Id")] Project1 project)
        {
            var existingProject = await _context.Projects
            .Where(p => p.Name == project.Name)
            .Select(p => p.Name)
            .FirstOrDefaultAsync();

            if (existingProject != null)
            {
                ModelState.AddModelError("Name", "Project with this name already exists.");
                ViewBag.Clients = new SelectList(_context.Clients, "Client_Id", "Email");
                return View("CreateProject" , project);
            }
            
            _context.Add(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetAllProjects));



        }




        [HttpGet]
        public async Task<IActionResult> DeleteProject(int? projectId, int page = 1)
        {
            if (projectId == null || _context.Projects == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
            .Include(p => p.Client)
            .Include(p => p.Task)
            .Select(p => new Project1 { Project_Id = p.Project_Id, Name = p.Name, StartDate = p.StartDate, DueDate = p.DueDate })
            .FirstOrDefaultAsync(m => m.Project_Id == projectId);
            if (project == null)
            {
                return NotFound();
            }
            ViewBag.PageIndex = Request.Query["page"];
            return View(project);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int projectId, int page = 1)
        {
            if (_context.Projects == null)
            {
                return Problem("Entity set 'MyDatabaseContext.Projects' is null.");
                
            }

            var project = await _context.Projects
            .Include(p => p.Client)
            .Include(p => p.Task)
            .Select(p => new Project1 { Project_Id = p.Project_Id, Name = p.Name, StartDate = p.StartDate, DueDate = p.DueDate })
            .FirstOrDefaultAsync(m => m.Project_Id == projectId);
            if (project != null)
            {
                if (project.Task != null)
                {
                    ModelState.AddModelError("Error", "Cannot delete project with existing tasks.");
                    ViewData["Error"] = "Cannot delete project with existing tasks.";
                    return View("DeleteProject", project);
                }
                _context.Projects.Remove(project);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetAllProjects), new { page = page });

        }




      



        public IActionResult EditProject(int id, int page = 1)
        {
            var project = _context.Projects.FirstOrDefault(p => p.Project_Id == id);

            if (project == null)
            {
                return NotFound();
            }

            ViewBag.PageIndex = Request.Query["page"];
            ViewBag.Clients = new SelectList(_context.Clients, "Client_Id", "Email", project.Client_Id);
            return View(project);
        }


        [HttpPost]
        public IActionResult Edit(int id, Project1 project , int page = 1)
        {
       
            var existingProject = _context.Projects.FirstOrDefault(p => p.Project_Id == id);

          
            if (existingProject == null)
            {
                return NotFound();
            }

            
            existingProject.Name = project.Name;
            existingProject.StartDate = project.StartDate;
            existingProject.DueDate = project.DueDate;
            existingProject.Client_Id = project.Client_Id;
    
            _context.SaveChanges();

            return RedirectToAction("GetAllProjects", new { page = page });
        }



       


    }
}
