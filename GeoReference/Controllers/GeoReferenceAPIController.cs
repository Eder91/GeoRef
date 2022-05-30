using GeoReferenceAPI.Models.Dto;
using GeoReferenceAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeoReferenceAPI.Controllers
{
    [ApiController]
    [Route("api/georeferences")]
    public class GeoReferenceAPIController : Controller
    {
        private readonly IGeoReferenceRepository _geoReferenceRepository;
        protected ResponseDto _response;
        public GeoReferenceAPIController(IGeoReferenceRepository geoReferenceRepository)
        {
            _geoReferenceRepository = geoReferenceRepository;
            this._response = new ResponseDto();
        }

        [HttpGet("Get")]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<GeoReferenceDto> geoReferenceDtos = await _geoReferenceRepository.GetGeoReferences();
                _response.Result = geoReferenceDtos;
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
                GeoReferenceDto geoReferenceDto = await _geoReferenceRepository.GetDataByGeoRef(id);
                _response.Result = geoReferenceDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpGet("GetEstados")]
        public async Task<object> GetEstados()
        {
            try
            {
                GeoReferenceVM geoReferenceVM = await _geoReferenceRepository.GetEstados();
                _response.Result = geoReferenceVM;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPost("Post")]
        public async Task<object> Post([FromBody] GeoReferenceDto geoReferenceDto)
        {
            try
            {
                GeoReferenceDto geoReference = await _geoReferenceRepository.CreateUpdateGeoReference(geoReferenceDto);
                _response.Result = geoReference;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpPut("Put")]
        public async Task<object> Put([FromBody] GeoReferenceDto geoReferenceDto)
        {
            try
            {
                GeoReferenceDto geoReference = await _geoReferenceRepository.CreateUpdateGeoReference(geoReferenceDto);
                _response.Result = geoReference;
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
                bool isSuccess = await _geoReferenceRepository.DeleteGeoReference(id);
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
