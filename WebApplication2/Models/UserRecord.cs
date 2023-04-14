using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebApplication2.Models
{
    public class UserRecord
    {
        [Key]
        public int? UserRecord_Id { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }


        [Required(ErrorMessage = "Start time is required.")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm\\:ss}")]
        public string? StartTime { get; set; }

        [Required(ErrorMessage = "End time is required.")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm\\:ss}")]
        public string? EndTime { get; set; }


        [Required(ErrorMessage = "The Task ID is required.")]
        [Display(Name = "Task ID")]
        [DisplayFormat(DataFormatString = "{0}")]
        public int? Task_Id { get; set; }

        [Required(ErrorMessage = "The  User ID is required.")]
        [Display(Name = "User ID")]
        [DisplayFormat(DataFormatString = "{0}")]
        public int? User_Id { get; set; }


        //  relational mapping between entities , join the data in queries.
        //  access the related entities through their navigation
        public virtual Task1? Task { get; set; }
        public virtual User? User { get; set; }

    }
}
