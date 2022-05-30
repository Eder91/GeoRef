using EstadoAPI.Models.Dto;

namespace EstadoAPI.Repository
{
    public interface IEstadosRepository
    {
        public Task<IEnumerable<EstadosDto>> GetEstados();
        public Task<EstadosDto> GetEstadoById(int idEstado);
        public Task<EstadosDto> CreateUpdateEstado(EstadosDto estadosDto);
        public Task<bool> DeleteEstado(int idEstado);
    }
}
