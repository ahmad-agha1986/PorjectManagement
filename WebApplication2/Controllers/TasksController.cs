using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Channels;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApplication2.Models;

using System;
using MailKit.Search;

namespace WebApplication2.Controllers
{

    public class TasksController : Controller
    {
        private readonly MyDatabaseContext _context;
        private List<int> availableTaskIds = new List<int>();

        public TasksController(MyDatabaseContext context)
        {
            _context = context;
        }

        

        public IActionResult TasksWithoutUsers(int page = 1, string searchTerm = "")
        {
            int pageSize = 10;
            List<Task1> tasks = _context.Tasks.Include(t => t.User).ToList();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                tasks = tasks.Where(t =>
                    t.Status.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    t.Task_Id.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Find tasks without users
            var tasksWithoutUsers = tasks.Where(t => t.User == null);

            // Find tasks with assigned users
            var tasksWithUsers = tasks.Where(t => t.User != null);

            var allTasks = tasksWithoutUsers.Concat(tasksWithUsers).ToList();
            int totalCount = allTasks.Count();
            int skip = (page - 1) * pageSize;
            var tasksToShow = allTasks.Skip(skip).Take(pageSize).ToList();

            var viewModel = new PaginationViewModel<Task1>
            {
                Items = tasksToShow,
                PageIndex = page,
                TotalPages = (int)Math.Ceiling((double)totalCount / pageSize)
            };

            return View(viewModel);
        }









        [HttpGet]
        public IActionResult AssignUser1(int id , int page = 1)

        {
            var task = _context.Tasks.FirstOrDefault(t => t.Task_Id == id);

            if (task == null)
            {
                return NotFound();
            }

            List<Task1> tasks = _context.Tasks.Include(t => t.User).ToList();
           var tasksWithoutUsers = tasks.Where(t => t.User == null);
           var tasksWithoutUsersIds = tasksWithoutUsers.Select(t => t.Task_Id).ToList();


                    // Find eligible users
                    var eligibleUsers = _context.Users
                    .Where(u => !u.OnLeave.HasValue || (u.OnLeave.HasValue && u.OnLeave.Value == false)
                     && u.Task.Count(t => t.Status == "InProgress") < 3
                     && !u.Task.Any(t => tasksWithoutUsersIds.Contains(t.Task_Id))
                     && !u.Task.Any(t => t.Status == "InProgress" && t.EndDate >= task.StartDate && t.StartDate <= task.EndDate))
                    .Select(u => new SelectListItem { Value = u.User_Id.ToString(), Text = u.User_Id.ToString() })
                    .ToList();



            var viewModel = new AssignUserViewModel
            {
                EligibleUsers = eligibleUsers,
                TaskId = task.Task_Id,
                 Task = task
                 
            };

            ViewBag.PageIndex = Request.Query["page"];

            return View(viewModel);
        }




        [HttpPost]
        public IActionResult AssignUser(int taskId, int userId , int page=1)
        {

            var viewModel = new AssignUserViewModel
            {
               
            };
            var task = _context.Tasks.FirstOrDefault(t => t.Task_Id == taskId);

            if (task == null)
            {
                return NotFound();
            }

            var user = _context.Users.FirstOrDefault(u => u.User_Id == userId);
   

            if (user == null)
            {
                return NotFound();
            }

           
            if (task.Status == "Complete")
            {
                ModelState.AddModelError("Error", "Cannot assign users on a completed task.");
                ViewData["Error"] = "Cannot assign users on a completed task .";
                     

                return View("AssignUser1", viewModel );
            }

            else
            {
                task.User_Id = user.User_Id;
                task.Status = "InProgress";
                _context.SaveChanges();

              
                // Create a notification for the user
                var notification = new Notification
                {
                    Type = "Email",
                    Message = $"You have been assigned to task # {task.Task_Id}",
                    Created_at = DateTime.Now,
                    User_Id = user.User_Id,
                    IsRead = false
                };
                _context.Notifications.Add(notification);
                _context.SaveChanges();
            }

            

            return RedirectToAction("TasksWithoutUsers", new { page = page });
        }




        [HttpGet]
        public IActionResult  UnassignUser (int taskId, int userId, int page = 1)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Task_Id == taskId);

            if (task == null)
            {
                return NotFound();
            }

            var user = _context.Users.FirstOrDefault(u => u.User_Id == userId);


            if (user == null)
            {
                return NotFound();
            }

         

              task.Status = "Unassigned";
                task.User = null;
                _context.SaveChanges();

           

            var notification = new Notification
            {
                Type = "Email",
                Message = $"You are no longer assigned to task # {task.Task_Id}",
                Created_at = DateTime.Now,
                User_Id = user.User_Id,
                IsRead = false
            };
            _context.Notifications.Add(notification);
            _context.SaveChanges();


            return RedirectToAction("TasksWithoutUsers", new{page = page});

        }


      



        public IActionResult CreateTask()
        {
            var projects = _context.Projects.Select(p => new { p.Project_Id, p.Name, p.DueDate }).ToList();
            ViewBag.Projects = new SelectList(projects, "Project_Id", "Name");
            return View();  
           
        }

      


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTask1([Bind("Task_Id,Name,Description,TimeEstimate,StartDate,EndDate,Status,Project_Id,User_Id")] Task1 task)
        {
            var existingTask = await _context.Tasks.FirstOrDefaultAsync(t => t.Name == task.Name );
            if (existingTask != null)
            {
                ModelState.AddModelError("", "A task with this name already exists.");
                var projects = _context.Projects.Select(p => new { p.Project_Id, p.Name, p.DueDate }).ToList();
                ViewBag.Projects = new SelectList(projects, "Project_Id", "Name");
                return View("CreateTask", task);
            }

            task.Status = "Unassigned";
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return RedirectToAction("TasksWithoutUsers");
        }





        [HttpGet]
        public async Task<IActionResult> DeleteTask(int? taskId ,  int page = 1 )
        {
            if (taskId == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var task1 = await _context.Tasks
                .Include(t => t.Project)
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.Task_Id == taskId);
            if (task1 == null)
            {
                return NotFound();
            }

            ViewBag.PageIndex = Request.Query["page"];
            return View(task1);
        }


      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? taskId , int page = 1)
        {
            if (_context.Tasks == null)
            {
                return Problem("Entity set 'MyDatabaseContext.Tasks'  is null.");
            }
            var task1 = await _context.Tasks.FindAsync(taskId);
            if (task1 != null)
            {
                if (task1.Status == "InProgress")
                {
                    ModelState.AddModelError("Error", "Cannot delete task with in-progress status.");
                    ViewData["Error"] = "Cannot delete task with in-progress status.";
                    return View("DeleteTask", task1);

                   
                }
                _context.Tasks.Remove(task1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("TasksWithoutUsers", new{page = page});


        }





       



    }
}
      









   
