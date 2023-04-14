using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Notification
    {
        [Key]
        public int? Notification_Id { get; set; }

        [Required(ErrorMessage = "Notification type is required")]
        [StringLength(50, ErrorMessage = "Notification type cannot be longer than 50 characters")]
        public string? Type { get; set; }

        [Required(ErrorMessage = "Notification message is required")]
        [StringLength(500, ErrorMessage = "Notification message cannot be longer than 500 characters")]
        public string? Message { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? Created_at { get; set; }


        [Required(ErrorMessage = "User is required")]
        [Display(Name = "User_Id")]
        [DisplayFormat(DataFormatString = "{0}")]
        public int? User_Id { get; set; }

        public bool? IsRead { get; set; }

        //  relational mapping between entities , join the data in queries.
        //  access the related entities through their navigation 
        public virtual User? User { get; set; }
    }
}
