using System.ComponentModel.DataAnnotations;

namespace BlazorServerTemplate.Data.Models
{
    public class ContactInputModel
    {

        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string? ContactName { get; set; }

        [Required]
        [Phone]
        [StringLength(15, ErrorMessage = "Name is too long.")]
        public string? ContactPhone { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(80, ErrorMessage = "Name is too long.")]
        public string? ContactEmail { get; set; }

        public string ProjectId { get; set; }
    }
}
