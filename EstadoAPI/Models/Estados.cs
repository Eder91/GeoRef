using System.ComponentModel.DataAnnotations;

namespace EstadoAPI.Models
{
    public class Estados
    {
        [Key]
        public int idEstado { get; set; } = 0;
        [Required]
        public string Descripcion { get; set; } = string.Empty;
        [Required]
        public string Clave_Fiscal { get; set; } = string.Empty;
    }
}
