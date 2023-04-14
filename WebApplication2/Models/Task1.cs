using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Task1
    {
        [Key]
        
        public int? Task_Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }

       

        [Required(ErrorMessage = "Time estimate is required.")]
        [DisplayFormat(DataFormatString = "{0:0.##} hours")]
        public double? TimeEstimate { get; set; }


        [Required(ErrorMessage = "Start date is required.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? StartDate { get; set; } 

        [Required(ErrorMessage = "End date is required.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? EndDate { get; set; }


        
        public string? Status { get; set; }

       
        [Display(Name = "Project_Id")]
        [DisplayFormat(DataFormatString = "{0}")]
        public int? Project_Id { get; set; } 

    
        [Display(Name = "User_Id")]
        [DisplayFormat(DataFormatString = "{0}")]
        public int? User_Id { get; set; }

      

        //  relational mapping between entities , join the data in queries.
        //  access the related entities through their navigation 
        public virtual User? User { get; set; }
        public virtual Project1? Project{ get; set; }

        public virtual ICollection<UserRecord>? UserRecords { get; set; }
       

    }
}
