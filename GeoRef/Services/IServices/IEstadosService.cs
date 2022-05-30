using GeoRef.Models;

namespace GeoRef.Services.IServices
{
    public interface IEstadosService
    {
        Task<T> GetAllEstadosAsync<T>();
        Task<T> GetEstadoByIdAsync<T>(int id);
        Task<T> CreateEstadoAsync<T>(EstadosDto estadosDto);
        Task<T> UpdateEstadosAsync<T>(EstadosDto estadosDto);
        Task<T> DeleteEstadoAsync<T>(int id);
    }
}
