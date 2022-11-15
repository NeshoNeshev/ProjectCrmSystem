using System.ComponentModel.DataAnnotations;

namespace BlazorServerTemplate.Services.ServiceModels
{
    public class IssueInputModel
    {
        [Required]
        [StringLength(30, ErrorMessage = "Name is too long.")]
        public string? Name { get; set; }


        [Required]
        [StringLength(10, ErrorMessage = "Date is too long.")]
        public string? Information { get; set; }


        public string? ProjectId { get; set; }

        public string? Author { get; set; }
    }
}
