using GeoReferenceAPI.Models.Dto;
using System.Collections.Generic;

namespace GeoReferenceAPI.Repository
{
    public interface IGeoReferenceRepository
    {
        public Task<IEnumerable<GeoReferenceDto>> GetGeoReferences();
        public Task<GeoReferenceDto> GetDataByGeoRef(int id);
        public Task<GeoReferenceDto> CreateUpdateGeoReference(GeoReferenceDto geoReferenceDto);
        public Task<bool> DeleteGeoReference(int id);
        public Task<GeoReferenceVM> GetEstados();
    }
}
