using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAPI.Models
{
    public class Estados
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idEstado { get; set; } = 0;
        [Required]
        public string Descripcion { get; set; } = string.Empty;
        [Required]
        public string Clave_Fiscal { get; set; } = string.Empty;
    }
}
