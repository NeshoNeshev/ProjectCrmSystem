namespace BlazorServerTemplate.Services
{
    public interface ICreate<T>
    {
        Task<bool> CreateAsync(T entity);

        
    }
}