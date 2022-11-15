using BlazorServerTemplate.Data.Models;
using BlazorServerTemplate.Data.Repositories;
using BlazorServerTemplate.Services.Mapping;
using BlazorServerTemplate.Services.ServiceModels;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace BlazorServerTemplate.Services
{
    public class ProjectService : ICreate<ProjectInputModel>, IDelete<string>
    {
        private readonly IDeletableEntityRepository<Project> projectRepository;
        public ProjectService(IDeletableEntityRepository<Project> projectRepository)
        {
            this.projectRepository = projectRepository;
        }
       
        public async Task<bool> CreateAsync(ProjectInputModel entity)
        {
            var exist = await this.projectRepository.All().FirstOrDefaultAsync(x => x.Name == entity.Name);

            if (exist != null)
            {
                return false;
            }
            else
            {
                try
                {
                    await this.projectRepository.AddAsync(new Project()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = entity.Name,
                        StartDate = DateTime.Now.ToString(),
                        EndDate = entity.EndDate,
                        MoreInformation = entity.MoreInformation,
                        Specification = entity.Specification,
                        Technology = entity.Technology,
                        Budget = entity.Budget,
                        Host = entity.Host,
                        EndHostingDate = entity.EndHostingDate,
                        Domain = entity.Domain,
                        EndDomainDate = entity.EndDomainDate,
                    });
                    await this.projectRepository.SaveChangesAsync();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw new InvalidOperationException("Project not created");
                }
            }
        }

        public  async Task<bool> DeleteAsync(string id)
        {
            var exist = await this.projectRepository.All().FirstOrDefaultAsync(x=>x.Id == id);
            if (exist == null)
            {
                return false;
            }
            else
            {

                this.projectRepository.Delete(exist);
               await this.projectRepository.SaveChangesAsync();

                return true;
            }
        }
        public async Task<string> GetIdAsync(string name)
        {
            var project = await this.projectRepository.All().FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());

            return project.Id;
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            IQueryable<Project> query = this.projectRepository.All();
           
            var result = await query.To<T>().ToListAsync();
            return result;
        }
        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<Project> query = this.projectRepository.All();
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }
            var result = await query.To<T>().ToListAsync();
            return result;
        }
        public async Task<IEnumerable<T>> GetByIdAsync<T>(string Id)
        {
            IQueryable<Project> query = this.projectRepository.All().Where(x=>x.Id == Id);
           
            var result = await query.To<T>().ToListAsync();
            return result;
        }
    }
}
