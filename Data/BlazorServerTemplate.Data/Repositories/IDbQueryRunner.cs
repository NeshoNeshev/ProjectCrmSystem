﻿namespace BlazorServerTemplate.Data.Repositories
{
    public interface IDbQueryRunner : IDisposable
    {
        Task RunQueryAsync(string query, params object[] parameters);
    }
}
