﻿using BlazorServerTemplate.Data.Repositories;

namespace BlazorServerTemplate.Services
{
    public interface IEdit<T>
    {
        Task<bool> EditAsync(T entity);

     
    }
}
