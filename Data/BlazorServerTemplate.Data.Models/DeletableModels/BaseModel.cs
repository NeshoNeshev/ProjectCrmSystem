
using BlazorServerTemplate.Data.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerTemplate.Data.Models.DeletableModels
{
    public abstract class BaseModel<TKey> : IDateInfo
    {
        [Key]
        public TKey Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
