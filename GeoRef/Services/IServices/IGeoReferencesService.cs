using GeoRef.Models;

namespace GeoRef.Services.IServices
{
    public interface IGeoReferencesService
    {
        Task<T> GetAllGeoReferenceAsync<T>();
        Task<T> GetGeoReferenceByIdAsync<T>(int id);
        Task<T> GetEstados<T>();
        Task<T> CreateGeoReferenceAsync<T>(GeoReferenceDto geoReferenceDto);
        Task<T> UpdateGeoReferenceAsync<T>(GeoReferenceDto geoReferenceDto);
        Task<T> DeleteGeoReferenceAsync<T>(int id);
    }
}
