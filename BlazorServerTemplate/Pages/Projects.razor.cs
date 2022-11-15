using BlazorServerTemplate.Data.Models;
using BlazorServerTemplate.Services;
using BlazorServerTemplate.Services.ServiceModels;
using BlazorServerTemplate.ViewModels;
using EllipticCurve.Utils;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;

namespace BlazorServerTemplate.Pages
{
    partial class Projects
    {
        [Inject]
        private ProjectService projectService { get; set; }
        [Inject]
        private ContactService contactService { get; set; }
        RadzenDataGrid<ProjectViewModel>? grid;
        private IEnumerable<ProjectViewModel> projects = new List<ProjectViewModel>();

        protected override async Task OnInitializedAsync()
        {
            projects = await this.projectService.GetAllAsync<ProjectViewModel>();
           await base.OnInitializedAsync();
        }
        void RowRender(RowRenderEventArgs<ProjectViewModel> args)
        {
           // args.Expandable = args.Data.ShipCountry == "France" || args.Data.ShipCountry == "Brazil";
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            if (firstRender)
            {
                await grid.ExpandRow(projects.FirstOrDefault());
            }
        }
    }
}
