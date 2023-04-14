using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication2.Models
{
    public class AssignUserViewModel
    {
        public List<SelectListItem> EligibleUsers { get; set; }
        public Task1 Task { get; set; }
        public int? TaskId { get; set; }
        public string TaskName { get; set; }
        public List<SelectListItem> Users { get; set; }
        public int? UserId { get; set; }
        public int PageIndex { get; set; }

    }
}
