using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MailKit.Search;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
      private readonly MyDatabaseContext _context;

        public UserController(MyDatabaseContext context)
        {
            _context = context;
        }



        // for user
        public IActionResult GetNotificationsView()
        {
            var userEmail = HttpContext.Session.GetString("userEmail");


            var notifications = _context.Notifications
                .Where(n => n.User.UserAuth.Email.ToLower() == userEmail.ToLower() )
                .Select(n => new
                {
                    NotificationId = n.Notification_Id,
                    Type = n.Type,
                    Message = n.Message,
                    CreatedAt = n.Created_at,
                   
                })
                .ToList();

            var jsonNotifications = JsonConvert.SerializeObject(notifications);

            

            var viewModel = new NotificationsViewModel
            {
                Notifications = JsonConvert.DeserializeObject<List<dynamic>>(jsonNotifications),
                UserEmail = userEmail
            };

            return View(viewModel);

        }

        // for user

        [HttpPost]
        public IActionResult DeleteNotification(int id )
        {
            var notification = _context.Notifications.FirstOrDefault(n => n.Notification_Id == id);

            if (notification != null)
            {
                _context.Notifications.Remove(notification);
                _context.SaveChanges();
            }

            return RedirectToAction("GetNotificationsView");
        }





        // for user page 
        public IActionResult MyTasks()
        {
            var userEmail = HttpContext.Session.GetString("userEmail");

            var tasks = _context.Tasks
                .Where(t => t.User.UserAuth.Email.ToLower() == userEmail.ToLower())
                .Select(t => new
                {
                    Task_Id = t.Task_Id,
                    Name = t.Name,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate,
                    Status = t.Status

                })
                .ToList();

            var jsonTasks = JsonConvert.SerializeObject(tasks);

            return View(model: jsonTasks);
        }






       

        public IActionResult GetAllUsers(int page = 1, int pageSize = 10 , string searchTerm="")
        {
           
            List<User> users = _context.Users
                .Include(u => u.UserAuth)
                .ThenInclude(u => u.UserRole)
                .ThenInclude(ur => ur.Role)
            .ToList();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                users = users.Where(u =>
                    u.Job_Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    u.User_Id.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            int totalCount = users.Count();
            int totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

           
            int skip = (page - 1) * pageSize;
            List<User> usersToShow = users.Skip(skip).Take(pageSize).ToList();

           
            var viewModel = new PaginationViewModel<User>
            {
                Items = usersToShow,
                PageIndex = page,
                TotalPages = totalPages
            };

          
            ViewBag.CurrentPage = page;
            ViewBag.HasPreviousPage = (page > 1);
            ViewBag.HasNextPage = (page < totalPages);

            return View(viewModel);
        }

        // for admin

        public IActionResult DeleteUser(int id, int page = 1)
        {
            var user = _context.Users
                        .Include(u => u.UserAuth)
                        .ThenInclude(u => u.UserRole)
                        .ThenInclude(ur => ur.Role)
                        .FirstOrDefault(u => u.User_Id == id);
            if (user == null)
            {
                return NotFound();
            }
            ViewBag.PageIndex = Request.Query["page"];
            return View(user);
        }

        // for admin 

        [HttpPost]
        public IActionResult DeleteConfirmed(int id, int page = 1)
        {
            var user = _context.Users
            .Include(u => u.UserAuth)
            .Include(u => u.UserAuth.UserRole)
            .ThenInclude(ur => ur.Role)
            .FirstOrDefault(u => u.User_Id == id);

            if (user == null)
            {
                return NotFound();
            }

            // Check if the user has any in-progress tasks
            var inProgressTasks = _context.Tasks.Any(t => t.User.User_Id == user.User_Id && t.Status == "InProgress");
            if (inProgressTasks)
            {
                ModelState.AddModelError("Error", "Cannot delete user with in-progress task.");
                ViewData["Error"] = "Cannot delete user with in-progress task.";
                return View("DeleteUser", user);

            }

            var userAuth = user.UserAuth;

            _context.UserAuths.Remove(userAuth);
            _context.SaveChanges();

            // Delete any roles that are no longer associated with any users
            var rolesToDelete = _context.Roles
                .Where(r => !r.UserRoles.Any())
                .ToList();

            _context.Roles.RemoveRange(rolesToDelete);
            _context.SaveChanges();

            return RedirectToAction(nameof(GetAllUsers), new { page = page });
        }

        // for admin page

        [HttpPost]
        public IActionResult SetUserOnLeave(int userId, bool onLeave, int page=1)
        {
            var user = _context.Users.FirstOrDefault(u => u.User_Id == userId);
            if (user != null)
            {
                user.OnLeave = onLeave;
                _context.SaveChanges();
            }
            return RedirectToAction("GetAllUsers", new { page = page });
        }



        // for Admin Page

        [HttpGet]
        public async Task<IActionResult> EditUser(int id, int page = 1)
        {
              
            var user = await _context.Users.FirstOrDefaultAsync(u => u.User_Id == id);
            var userAuth = await _context.UserAuths.FirstOrDefaultAsync(ua => ua.Id == user.UserAuth_Id);


            var viewModel = new RegisterUserViewModel
            {
                User = user,
                UserAuth = userAuth
            };

            ViewBag.PageIndex = Request.Query["page"];
            return View(viewModel);
        }



        // for Admin Page

        [HttpPost]
        public async Task<IActionResult> Edit(int id, RegisterUserViewModel model , int page = 1)
        {
            // Retrieve the user and user authentication information from the database
            var userModel = await _context.Users.FirstOrDefaultAsync(u => u.User_Id == id);
            var userAuth = await _context.UserAuths.FirstOrDefaultAsync(ua => ua.Id == userModel.UserAuth_Id);

            if (userModel == null || userAuth== null)
            {
                return NotFound();
            }


            // Update the user information
            userAuth.Email = model.UserAuth.Email;
            userAuth.UserName = model.UserAuth.UserName;
            userModel.FirstName = model.User.FirstName;
            userModel.LastName = model.User.LastName;
            userModel.Job_Title = model.User.Job_Title;
            userModel.Phone = model.User.Phone;
           
            await _context.SaveChangesAsync();

            return RedirectToAction("GetAllUsers", new { page = page });
        }



        // for user page 

        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
            var userEmail = HttpContext.Session.GetString("userEmail");

            var user = await _context.Users
       .Include(u => u.UserAuth)
       .FirstOrDefaultAsync(u => u.UserAuth.Email.ToLower() == userEmail.ToLower());

            if (user == null)
            {
                return NotFound();
            }

            var viewModel = new RegisterUserViewModel
            {
                User = user,
                UserAuth = user.UserAuth
            };

            return View(viewModel);
        }




       // for user page 

        [HttpPost]
        public async Task<IActionResult> EditMyProfile(int userId, RegisterUserViewModel model)
        {
            // Retrieve the user and user authentication information from the database
            var userModel = await _context.Users.FirstOrDefaultAsync(u => u.User_Id == userId);
            var userAuth = await _context.UserAuths.FirstOrDefaultAsync(ua => ua.Id == userModel.UserAuth_Id);

            if (userModel == null || userAuth == null)
            {
                return NotFound();
            }


            // Update the user information
            userAuth.Email = model.UserAuth.Email;
            userAuth.UserName = model.UserAuth.UserName;
            userModel.FirstName = model.User.FirstName;
            userModel.LastName = model.User.LastName;
            userModel.Phone = model.User.Phone;

            await _context.SaveChangesAsync();

            return RedirectToAction("UserPage","Account");
        }

        // for user page
        public IActionResult AddWorkingHours()
        {
            var userEmail = HttpContext.Session.GetString("userEmail").ToLower();
            var userAuthId = _context.UserAuths
                .Where(u => u.Email.ToLower() == userEmail)
                .Select(u => u.Id)
                .FirstOrDefault();
            var userId = _context.Users
                .Where(u => u.UserAuth_Id == userAuthId)
                .Select(u => u.User_Id)
                .FirstOrDefault();

            var tasks = _context.Tasks
            .Where(t => t.User_Id == userId)
            .Select(t => new { t.Task_Id, t.Name, t.Status, t.StartDate, t.EndDate, t.TimeEstimate })
            .ToList();

            ViewBag.Tasks = new SelectList(tasks, "Task_Id", "Name");
            ViewBag.UserId = userId;
            return View();
        }


        // for user page

        [HttpPost]
        public IActionResult AddUserRecord(UserRecord userRecord)
        {
            
                _context.UserRecords.Add(userRecord);
                _context.SaveChanges();
                return RedirectToAction("UserPage", "Account");
           
            
        }



        // for admin page 


        public IActionResult GetUserRecord()
        {
            var userRecords = _context.UserRecords
                .Include(ur => ur.Task)
                    .ThenInclude(t => t.User)
                    .Include(ur => ur.User)
                .Select(ur => new TaskUserRecordViewModel
                {
                    Tasks = ur.Task,
                    Users = ur.User,
                    UserRecords = ur
                })
                .ToList();

            return View(userRecords);
        }


        // for user Page
        [HttpPost]
        public IActionResult UpdateTaskStatus(int id)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Task_Id == id);

            if (task != null && task.Status == "InProgress")
            {
                task.Status = "Complete";
                _context.SaveChanges();
            }
            else if (task != null && task.Status == "Complete")
            {
                task.Status = "InProgress";
                _context.SaveChanges();
            }

            return RedirectToAction("MyTasks");
        }





    }



}


