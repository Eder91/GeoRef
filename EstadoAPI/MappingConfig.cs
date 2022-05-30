using AutoMapper;
using EstadoAPI.Models;
using EstadoAPI.Models.Dto;

namespace EstadoAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mapping = new MapperConfiguration(config =>
            {
                config.CreateMap<EstadosDto, Estados>();
                config.CreateMap<Estados, EstadosDto>();
            });
            return mapping;
        }
    }
}
