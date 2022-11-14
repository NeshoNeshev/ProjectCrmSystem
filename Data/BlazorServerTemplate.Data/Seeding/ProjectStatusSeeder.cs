namespace BlazorServerTemplate.Data.Seeding
{
    public class ProjectStatusSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var statuses = new List<string>() {"Active","Completed", "Delay" };
            foreach (var item in statuses)
            {
                if (!dbContext.ProjectStatuses.Any(x=>x.Name == item))
                {
                    await dbContext.ProjectStatuses.AddAsync(new Models.ProjectStatus { Name = item });
                }
               
            }
        }
    }
}
