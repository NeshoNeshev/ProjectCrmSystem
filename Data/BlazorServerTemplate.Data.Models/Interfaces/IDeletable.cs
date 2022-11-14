namespace BlazorServerTemplate.Data.Models.Interfaces
{
    public interface IDeletable
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
