using GeoRef.Models;
using GeoRef.Services.IServices;

namespace GeoRef.Services
{
    public class EstadosService : BaseService, IEstadosService
    {
        private readonly IHttpClientFactory _clientFactory;
        public EstadosService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateEstadoAsync<T>(EstadosDto estadosDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = estadosDto,
                Url = SD.EstadoAPIBase + "/api/estados/Post",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteEstadoAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Data = id,
                Url = SD.EstadoAPIBase + "/api/estados/Delete/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllEstadosAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.EstadoAPIBase + "/api/estados/Get",
                AccessToken = ""
            });
        }

        public async Task<T> GetEstadoByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Data = id,
                Url = SD.EstadoAPIBase + "/api/estados/Get/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateEstadosAsync<T>(EstadosDto estadosDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = estadosDto,
                Url = SD.EstadoAPIBase + "/api/estados/Put",
                AccessToken = ""
            });
        }
    }
}
