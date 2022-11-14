using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerTemplate.Services
{
    public interface IDelete<T>
    {
        Task<bool> DeleteAsync(T entity);
    }
}
