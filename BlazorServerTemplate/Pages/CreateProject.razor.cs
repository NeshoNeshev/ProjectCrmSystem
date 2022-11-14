using BlazorServerTemplate.Data.Models;
using BlazorServerTemplate.Services;
using BlazorServerTemplate.Services.ServiceModels;
using Microsoft.AspNetCore.Components;

namespace BlazorServerTemplate.Pages
{
    partial class CreateProject
    {
        [Inject]
        private ProjectService projectService { get; set; }
        [Inject]
        private ContactService contactService { get; set; }

        private ProjectInputModel exampleModel = new();
        private ContactInputModel contactInputModel = new();
       
        bool IsProjectCompleted = false;
        ICollection<string> contacts = new List<string>();
        protected override Task OnInitializedAsync()
        {
            IsProjectCompleted = false;
            return base.OnInitializedAsync();
        }
        private async Task HandleValidSubmit()
        {
          var result = await projectService.CreateAsync(exampleModel);
            if (result)
            {
                IsProjectCompleted = true;
            }
           
        }
        private async void HandleValidSubmitContact()
        {
            contactInputModel.ProjectId = await this.projectService.GetIdAsync(exampleModel.Name);
            var result = await contactService.CreateAsync(contactInputModel);
            if (result)
            {
                contacts.Add(contactInputModel.ContactName);
                contactInputModel = new();
                StateHasChanged();
            }
        }
    }
}
