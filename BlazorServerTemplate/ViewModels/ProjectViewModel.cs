using BlazorServerTemplate.Data;
using BlazorServerTemplate.Data.Models;
using BlazorServerTemplate.Services.Mapping;

namespace BlazorServerTemplate.ViewModels
{
    public class ProjectViewModel : IMapFrom<Project>
    {
        public string? Id { get; set; }
        public string? Name { get; set; }

        public string? StartDate { get; set; }

        public string? EndDate { get; set; }

        public string? MoreInformation { get; set; }
        public string? Specification { get; set; }
        public string? Technology { get; set; }
        public decimal? Budget { get; set; }


        public string? Host { get; set; }
        public string? EndHostingDate { get; set; }
        public string? Domain { get; set; }

        public string? EndDomainDate { get; set; }

        public ICollection<IssueViewModel> Issues { get; set; }

        public ICollection<ContactViewModel> Contacts { get; set; }
    }
}
