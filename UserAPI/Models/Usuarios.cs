using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAPI.Models
{
    public class Usuarios : IdentityUser
    {
        [Key]
        public int idUsuario { get; set; } = 0;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "abcde";
        [Required]
        public string Nombre { get; set; } = string.Empty;
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public string RFC { get; set; } = string.Empty;
    }
}
