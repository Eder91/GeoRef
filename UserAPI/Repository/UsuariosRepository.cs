using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UserAPI.DbContexts;
using UserAPI.Models;
using UserAPI.Models.Dto;

namespace UserAPI.Repository
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public UsuariosRepository( ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<UsuariosDto> CreateUpdateUsuario(UsuariosDto usuariosDto)
        {
            Usuarios usuarios = _mapper.Map<Usuarios>(usuariosDto);
            if (usuarios.idUsuario > 0)
            {
                _db.Usuarios.Update(usuarios);
            }
            else
            {
                _db.Usuarios.Add(usuarios);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Usuarios, UsuariosDto>(usuarios);
        }

        public async Task<bool> DeleteUsuario(int idUsuario)
        {
            try
            {
                Usuarios usuarios = await _db.Usuarios.FirstOrDefaultAsync(x => x.idUsuario == idUsuario);
                if (usuarios == null)
                {
                    return false;
                }
                _db.Usuarios.Remove(usuarios);
                UsuariosRelEstado usuariosRelEstado = await _db.UsuariosRelEstados.FirstOrDefaultAsync(x => x.idUsuario == idUsuario);
                if (usuariosRelEstado != null)
                {
                    _db.UsuariosRelEstados.Remove(usuariosRelEstado);
                }
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<UsuariosDto> GetUsuarioById(int idUsuario)
        {
            Usuarios usuarios = await _db.Usuarios.Where(x => x.idUsuario == idUsuario).FirstOrDefaultAsync();
            return _mapper.Map<UsuariosDto>(usuarios);
        }

        public async Task<IEnumerable<UsuariosDto>> GetUsuarios()
        {
            IEnumerable<Usuarios> objList = await _db.Usuarios.ToListAsync();
            return _mapper.Map<List<UsuariosDto>>(objList);
        }

        public async Task<UsuariosVMDto> UseEstadosForUser()
        {
            UsuariosVMDto usuariosVM = new UsuariosVMDto()
            {
                TypeDropDown = _db.Estados.Select(x => new SelectListItem
                {
                    Text = x.Descripcion,
                    Value = x.idEstado.ToString()
                })
            };
            return _mapper.Map<UsuariosVMDto>(usuariosVM);
        }

    }
}
