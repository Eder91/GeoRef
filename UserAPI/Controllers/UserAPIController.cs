using Microsoft.AspNetCore.Mvc;
using UserAPI.Models.Dto;
using UserAPI.Repository;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UserAPIController : Controller
    {
        private readonly IUsuariosRepository _usuariosRepository;
        protected ResponseDto _response;
        public UserAPIController(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
            this._response = new ResponseDto();
        }
        [HttpGet("Get")]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<UsuariosDto> usuariosDtos = await _usuariosRepository.GetUsuarios();
                _response.Result = usuariosDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpGet("GetForUser")]
        public async Task<object> GetForUser()
        {
            try
            {
                UsuariosVMDto usuariosVMDto = await _usuariosRepository.UseEstadosForUser();
                _response.Result = usuariosVMDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpGet("Get/{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                UsuariosDto usuariosDto = await _usuariosRepository.GetUsuarioById(id);
                _response.Result = usuariosDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPost("Post")]
        public async Task<object> Post([FromBody] UsuariosDto usuariosDto)
        {
            try
            {
                UsuariosDto usuarios = await _usuariosRepository.CreateUpdateUsuario(usuariosDto);
                _response.Result = usuarios;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPut("Put")]
        public async Task<object> Put([FromBody] UsuariosDto usuariosDto)
        {
            try
            {
                UsuariosDto usuarios = await _usuariosRepository.CreateUpdateUsuario(usuariosDto);
                _response.Result = usuarios;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpDelete("Delete/{id}")]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _usuariosRepository.DeleteUsuario(id);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
    }
}
