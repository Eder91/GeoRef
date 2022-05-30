using AutoMapper;
using EstadoAPI.DbContexts;
using EstadoAPI.Models;
using EstadoAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace EstadoAPI.Repository
{
    public class EstadosRepository : IEstadosRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public EstadosRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
    
        public async Task<EstadosDto> CreateUpdateEstado(EstadosDto estadosDto)
        {
            Estados estado = _mapper.Map<EstadosDto,Estados>(estadosDto);
            if (estado.idEstado > 0)
            {
                _db.Estados.Update(estado);
            }
            else
            {
                _db.Estados.Add(estado);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Estados,EstadosDto>(estado);
        }

        public async Task<bool> DeleteEstado(int idEstado)
        {
            try
            {
                Estados estado = await _db.Estados.FirstOrDefaultAsync(x => x.idEstado == idEstado);
                if (estado == null)
                {
                    return false;
                }
                _db.Estados.Remove(estado);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<EstadosDto> GetEstadoById(int idEstado)
        {
            Estados estado = await _db.Estados.Where(x => x.idEstado == idEstado).FirstOrDefaultAsync();
            return _mapper.Map<EstadosDto>(estado);
        }

        public async Task<IEnumerable<EstadosDto>> GetEstados()
        {
            List<Estados> estadosList = await _db.Estados.ToListAsync();
            return _mapper.Map<List<EstadosDto>>(estadosList);
        }
    }
}
