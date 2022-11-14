using BlazorServerTemplate.Data.Models.Interfaces;

namespace BlazorServerTemplate.Data.Models.DeletableModels
{
    public abstract class BaseDeletableModel<TKey> : BaseModel<TKey>, IDeletable
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
