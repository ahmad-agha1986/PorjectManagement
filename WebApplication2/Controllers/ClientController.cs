using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ClientController : Controller
    {
        private readonly MyDatabaseContext _context;

        public ClientController(MyDatabaseContext context)
        {
            _context = context;
        }



      


        public IActionResult GetAllClients(int page = 1, int pageSize = 10, string searchTerm = "")
        {
            // Retrieve all clients from the database
            List<Client> clients = _context.Clients.ToList();

            // Filter clients based on search term if present
            if (!string.IsNullOrEmpty(searchTerm))
            {
                clients = clients.Where(c =>
                    c.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    c.Client_Id.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            int totalCount = clients.Count();
            int totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            // Get the clients for the requested page
            int skip = (page - 1) * pageSize;
            List<Client> clientsToShow = clients.Skip(skip).Take(pageSize).ToList();

            var viewModel = new PaginationViewModel<Client>
            {
                Items = clientsToShow,
                PageIndex = page,
                TotalPages = totalPages,
                SearchTerm = searchTerm
            };

            // Set the ViewBag properties for the view
            ViewBag.HasPreviousPage = (page > 1);
            ViewBag.HasNextPage = (page < totalPages);

            return View(viewModel);
        }








        public IActionResult CreateClient()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Client_Id,FirstName,LastName,Email,Phone,Address,City,State,Country")] Client client)
        {
            
                var existingClient = await _context.Clients.FirstOrDefaultAsync(c => c.Email == client.Email);
                if (existingClient != null)
                {
                    ModelState.AddModelError("", "A client with this email already exists.");
                    return View("CreateClient", client);
                }

                _context.Clients.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction("GetAllClients");
        }


        [HttpGet]
        public async Task<IActionResult> DeleteClient(int? clientId, int page = 1)
        {
            if (clientId == null || _context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .Include(c => c.Project)
                .FirstOrDefaultAsync(c => c.Client_Id == clientId);
            if (client == null)
            {
                return NotFound();
            }
            ViewBag.PageIndex = Request.Query["page"];
            return View(client);
        }



        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int clientId, int page = 1)
        {
            var client = await _context.Clients.FindAsync(clientId);
        
            if (client == null)
            {
                return NotFound();
            }

            try
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();

                return RedirectToAction("GetAllClients", new { page = page });
            }

          
            catch (Exception ex)
            {
              
                return RedirectToAction("Error", new { errorMessage = ex.Message });
            }


        }

        public IActionResult EditClient(int id, int page=1 )
        {
            var client = _context.Clients.FirstOrDefault(c => c.Client_Id == id);

            if (client == null)
            {
                return NotFound();
            }

            ViewBag.PageIndex = Request.Query["page"];

            return View(client);
        }


        [HttpPost]
        public IActionResult Edit(int id, Client client, int page=1)
        {
            var existingClient = _context.Clients.FirstOrDefault(c => c.Client_Id == id);

            if (existingClient == null)
            {
                return NotFound();
            }

            existingClient.FirstName = client.FirstName;
            existingClient.LastName = client.LastName;
            existingClient.Email = client.Email;
            existingClient.Phone = client.Phone;
            existingClient.Address = client.Address;
            existingClient.City = client.City;
            existingClient.State = client.State;
            existingClient.Country = client.Country;

            _context.SaveChanges();

            return RedirectToAction("GetAllClients", new { page = page });
        }


    }

}
