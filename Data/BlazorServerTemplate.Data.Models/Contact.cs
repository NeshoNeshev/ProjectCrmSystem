using BlazorServerTemplate.Data.Models.DeletableModels;

namespace BlazorServerTemplate.Data.Models
{
    public class Contact : BaseDeletableModel<string>
    {
        public string? Name { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? ProjectId { get; set; }

        public Project? Project { get; set; }
    }
}
