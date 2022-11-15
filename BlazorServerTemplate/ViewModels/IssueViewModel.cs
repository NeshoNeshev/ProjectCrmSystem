using BlazorServerTemplate.Data;
using BlazorServerTemplate.Services.Mapping;

namespace BlazorServerTemplate.ViewModels
{
    public class IssueViewModel : IMapFrom<Issue>
    {
        public string? Name { get; set; }

        public string? Information { get; set; }
        //public string? Author { get; set; }
    }
}
