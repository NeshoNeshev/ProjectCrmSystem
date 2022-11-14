
namespace BlazorServerTemplate.Data.Models.Interfaces
{
    public interface IDateInfo
    {
        DateTime CreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}
