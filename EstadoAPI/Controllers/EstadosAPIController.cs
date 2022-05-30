using EstadoAPI.Models.Dto;
using EstadoAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EstadoAPI.Controllers
{
    [ApiController]
    [Route("api/estados")]
    public class EstadosAPIController : Controller
    {
        protected ResponseDto _response;
        private IEstadosRepository _estadosRepository;
        public EstadosAPIController(IEstadosRepository estadosRepository)
        {
            _estadosRepository = estadosRepository;
            this._response = new ResponseDto();
        }

        [HttpGet("Get")]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<EstadosDto> estadosDtos = await _estadosRepository.GetEstados();
                _response.Result = estadosDtos;
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
                EstadosDto estados = await _estadosRepository.GetEstadoById(id);
                _response.Result = estados;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("Post")]
        public async Task<object> Post([FromBody] EstadosDto estadosDto)
        {
            try
            {
                EstadosDto estado = await _estadosRepository.CreateUpdateEstado(estadosDto);
                _response.Result = estado;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }


        [HttpPut("Put")]
        public async Task<object> Put([FromBody] EstadosDto estadosDto)
        {
            try
            {
                EstadosDto estado = await _estadosRepository.CreateUpdateEstado(estadosDto);
                _response.Result = estado;
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
                bool isSuccess = await _estadosRepository.DeleteEstado(id);
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
