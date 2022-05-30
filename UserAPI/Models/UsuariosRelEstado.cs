using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAPI.Models
{
    public class UsuariosRelEstado
    {
        [Key]
        public int idPermiso { get; set; }
        public int idUsuario { get; set; }
        public int idEstado { get; set; }
        [ForeignKey("idEstado")]
        public virtual Estados Estados { get; set; }
    }
}
