using AutoMapper;
using UserAPI.Models;
using UserAPI.Models.Dto;

namespace UserAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mapping = new MapperConfiguration(config =>
            {
                config.CreateMap<UsuariosDto, Usuarios>();
                config.CreateMap<UsuariosRelEstadoDto, UsuariosRelEstado>();
                config.CreateMap<EstadosDto, Estados>();
                config.CreateMap<Usuarios, UsuariosDto>();
                config.CreateMap<UsuariosRelEstado, UsuariosRelEstadoDto>();
                config.CreateMap<Estados, EstadosDto>();
                config.CreateMap<UsuariosVMDto, UsuariosVMDto>();
            });
            return mapping;
        }
    }
}
