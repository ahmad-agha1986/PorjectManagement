using static ServiceStack.LicenseUtils;
using System.ComponentModel.DataAnnotations;

public class Email
{
    [Key]
    public int? Email_Id { get; set; }

    [Required(ErrorMessage = "Please enter a sender email address.")]
    [EmailAddress(ErrorMessage = "Please enter a valid sender email address.")]
    public string SenderEmail { get; set; }

    [Required(ErrorMessage = "Please enter a recipient email address.")]
    [EmailAddress(ErrorMessage = "Please enter a valid recipient email address.")]
    public string RecipientEmail { get; set; }

    [Required(ErrorMessage = "Please enter a subject.")]
    public string Subject { get; set; }

    [Required(ErrorMessage = "Please enter a body.")]
    public string Body { get; set; }

    public byte[] Attachment { get; set; }
    public string AttachmentName { get; set; }
    public string AttachmentContentType { get; set; }
    public DateTime DateSent { get; set; }
}