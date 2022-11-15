using BlazorServerTemplate.Data.Models;
using BlazorServerTemplate.Services.Mapping;

namespace BlazorServerTemplate.ViewModels
{
    public class ContactViewModel : IMapFrom<Contact>
    {
        public string? Name { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }
    }
}
