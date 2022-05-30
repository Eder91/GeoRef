using GeoRef.Models;
using GeoRef.Services.IServices;

namespace GeoRef.Services
{
    public class GeoReferenceService : BaseService, IGeoReferencesService
    {
        private readonly IHttpClientFactory _clientFactory;
        public GeoReferenceService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateGeoReferenceAsync<T>(GeoReferenceDto geoReferenceDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = geoReferenceDto,
                Url = SD.GeoReferenceAPIBase + "/api/georeferences/Post",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteGeoReferenceAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Data = id,
                Url = SD.GeoReferenceAPIBase + "/api/georeferences/Delete/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllGeoReferenceAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.GeoReferenceAPIBase + "/api/georeferences/Get",
                AccessToken = ""
            });
        }

        public async Task<T> GetEstados<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.GeoReferenceAPIBase + "/api/georeferences/GetEstados",
                AccessToken = ""
            });
        }

        public async Task<T> GetGeoReferenceByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Data = id,
                Url = SD.GeoReferenceAPIBase + "/api/georeferences/Get/" + id,
                AccessToken = ""
            });
        }
        
        public async Task<T> UpdateGeoReferenceAsync<T>(GeoReferenceDto geoReferenceDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = geoReferenceDto,
                Url = SD.GeoReferenceAPIBase + "/api/georeferences/Put",
                AccessToken = ""
            });
        }
    }
}
