using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace WebApplication2.Models
{
    public class Project1
    {
        [Key]
        public int? Project_Id { get; set; }

        [Required(ErrorMessage = "The project name is required.")]
        [Display(Name = "Project Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = " Start Date is required.")]
        public DateTime? StartDate { get; set; }



        [Required(ErrorMessage = "Due date is required.")]
        public DateTime? DueDate { get; set; }



        [Required(ErrorMessage = "The project status is required.")]
        public string? Status { get; set; } = string.Empty;


        [Required(ErrorMessage = "The client ID is required.")]
        [Display(Name = "Client ID")]
        [DisplayFormat(DataFormatString = "{0}")]
        public int? Client_Id { get; set; } = -1; 

        //  relational mapping between entities , join the data in queries.
        //  access the related entities through their navigation 
        public virtual Client? Client { get; set; }
        public virtual ICollection<Task1>? Task { get; set; }
    }
}
