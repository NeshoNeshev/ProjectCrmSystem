

using System.ComponentModel.DataAnnotations;

namespace BlazorServerTemplate.Services.ServiceModels
{
    public class ProjectInputModel
    {

        [Required]
        [StringLength(30, ErrorMessage = "Name is too long.")]
        public string? Name { get; set; }


        [Required]
        [StringLength(10, ErrorMessage = "Date is too long.")]
        public string? EndDate { get; set; }


        [Required]
        [StringLength(80, ErrorMessage = "Name is too long.")]
        public string? Technology { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid doubleNumber")]
        public decimal? Budget { get; set; }


        [StringLength(80, ErrorMessage = "Name is too long.")]

        public string? Host { get; set; }
        [Required]
        [StringLength(300, ErrorMessage = "Is too long.")]
        public string? MoreInformation { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Name is too long.")]
        public string? Specification { get; set; }
        [StringLength(10, ErrorMessage = "Date is too long.")]
        public string? EndHostingDate { get; set; }

        [StringLength(20, ErrorMessage = "Domain is too long.")]
        public string? Domain { get; set; }

        [StringLength(10, ErrorMessage = "Date is too long.")]
        public string? EndDomainDate { get; set; }

    }

}