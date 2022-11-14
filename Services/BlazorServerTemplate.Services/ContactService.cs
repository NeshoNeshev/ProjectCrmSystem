
using BlazorServerTemplate.Data.Models;
using BlazorServerTemplate.Data.Repositories;

namespace BlazorServerTemplate.Services
{
    public class ContactService : ICreate<ContactInputModel>
    {
        private readonly IDeletableEntityRepository<Contact> contactRepository;
        public ContactService(IDeletableEntityRepository<Contact> contactRepository)
        {
            this.contactRepository = contactRepository;
        }
        public async Task<bool> CreateAsync(ContactInputModel entity)
        {
           var exist = this.contactRepository.All().Any(x=>x.Email == entity.ContactEmail);
            if (!exist)
            {
                await this.contactRepository.AddAsync(new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = entity.ContactName,
                    Email = entity.ContactEmail,
                    Phone = entity.ContactPhone,
                    ProjectId = entity.ProjectId,
                });
                await this.contactRepository.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
