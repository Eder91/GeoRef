using AutoMapper;
using GeoReferenceAPI.Models;
using GeoReferenceAPI.Models.Dto;

namespace GeoReferenceAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mapping = new MapperConfiguration(config =>
            {
                config.CreateMap<GeoReferenceDto, GeoReference>();
                config.CreateMap<EstadosDto, Estados>();
                config.CreateMap<GeoReference, GeoReferenceDto>();
                config.CreateMap<Estados, EstadosDto>();
            });
            return mapping;
        }
    }
}
