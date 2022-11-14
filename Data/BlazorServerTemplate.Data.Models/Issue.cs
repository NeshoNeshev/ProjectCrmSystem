using BlazorServerTemplate.Data.Models;
using BlazorServerTemplate.Data.Models.DeletableModels;

namespace BlazorServerTemplate.Data
{
    public class Issue : BaseDeletableModel<string>
    {
        public string? Name { get; set; }

        public string? Information { get; set; }

        public string? ProjectId{ get; set; }

        public string? Author { get; set; }

        public virtual Project?  Project { get; set; }
    }
}
