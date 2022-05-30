using GeoRef.Models;

namespace GeoRef.Services.IServices
{
    public interface IUsuariosService
    {
        Task<T> GetAllUsuariosAsync<T>();
        Task<T> GetUsuariosByIdAsync<T>(int id);
        Task<T> CreateUsuarioAsync<T>(UsuariosDto usuariosdto);
        Task<T> UpdateUsuarioAsync<T>(UsuariosDto usuariosdto);
        Task<T> DeleteUsuarioAsync<T>(int id);
        Task<T> GetForUser<T>();
    }
}
