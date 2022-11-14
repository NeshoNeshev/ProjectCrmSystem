using BlazorServerTemplate.Data.Models.DeletableModels;

namespace BlazorServerTemplate.Data.Models
{
    public class Project : BaseDeletableModel<string>
    {
        public Project()
        {
            this.Issues = new HashSet<Issue>();
            this.Contacts = new HashSet<Contact>();
        }
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

        public string? ProjectStatusId { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}
