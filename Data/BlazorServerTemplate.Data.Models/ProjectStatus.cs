

using BlazorServerTemplate.Data.Models.DeletableModels;

namespace BlazorServerTemplate.Data.Models
{
    public class ProjectStatus : BaseDeletableModel<string>
    {
        public ProjectStatus()
        {
            this.Projects = new HashSet<Project>();
        }

        public string? Name { get; set; }
       
        public virtual ICollection<Project> Projects { get; set; }
    }
}
