using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersAPI.Models.Dto
{
    public class UsuariosRelEstadoDto
    {
        public int idPermiso { get; set; }
        public int idUsuario { get; set; }
        public int idEstado { get; set; }
        public virtual EstadosDto EstadosDto { get; set; }
    }
}
