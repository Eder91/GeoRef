using GeoRef.Models;
using GeoRef.Services.IServices;

namespace GeoRef.Services
{
    public class UsuariosService : BaseService, IUsuariosService
    {
        private readonly IHttpClientFactory _clientFactory;
        public UsuariosService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateUsuarioAsync<T>(UsuariosDto usuariosdto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = usuariosdto,
                Url = SD.UserAPIBase + "/api/usuarios/Post",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteUsuarioAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Data = id,
                Url = SD.UserAPIBase + "/api/usuarios/Delete/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllUsuariosAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.UserAPIBase + "/api/usuarios/Get",
                AccessToken = ""
            });
        }

        public async Task<T> GetForUser<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.UserAPIBase + "/api/usuarios/GetForUser",
                AccessToken = ""
            });
        }

        public async Task<T> GetUsuariosByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Data = id,
                Url = SD.UserAPIBase + "/api/usuarios/Get/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateUsuarioAsync<T>(UsuariosDto usuariosdto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = usuariosdto,
                Url = SD.UserAPIBase + "/api/usuarios/Put",
                AccessToken = ""
            });
        }
    }
}
