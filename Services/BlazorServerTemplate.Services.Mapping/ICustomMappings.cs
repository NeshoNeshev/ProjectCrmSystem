using AutoMapper;

namespace BlazorServerTemplate.Services.Mapping
{
    public interface ICustomMappings
    {
        void CreateMappings(IProfileExpression configuration);
    }
}