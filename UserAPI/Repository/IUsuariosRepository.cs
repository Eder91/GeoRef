using UserAPI.Models.Dto;

namespace UserAPI.Repository
{
    public interface IUsuariosRepository
    {

        Task<IEnumerable<UsuariosDto>> GetUsuarios();
        Task<UsuariosDto> GetUsuarioById(int idUsuario);
        Task<UsuariosDto> CreateUpdateUsuario(UsuariosDto usuariosDto);
        Task<bool> DeleteUsuario(int idUsuario);
        Task<UsuariosVMDto> UseEstadosForUser();
    }
}
