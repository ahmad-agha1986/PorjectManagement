using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class User
    {
        [Key]
        public int? User_Id { get; set; }

        [Required(ErrorMessage = "Job title is required")]
        public string? Job_Title { get; set; }


        [Required(ErrorMessage = "First name is required")]
        public string? FirstName { get; set; }


       [Required(ErrorMessage = "Last name is required")]
        public string? LastName { get; set; }
  
     


        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string? Phone { get; set; }




        [Required(ErrorMessage = "Registration date is required")]
        public DateTime? Registration_date { get; set; }

       // [Required(ErrorMessage = "Please indicate whether the user is on leave or not.")]
        public bool? OnLeave { get; set; }

        public int? UserAuth_Id { get; set; }


        //  relational mapping between entities , join the data in queries.
        //  access the related entities through their navigation 
        public virtual ICollection<Task1>? Task { get; set; }

        public virtual UserAuth UserAuth { get; set; }
        public virtual ICollection<Notification>? Notification { get; set; }
        public virtual ICollection<UserRecord>? UserRecords { get; set; }

    }
 
}
   
