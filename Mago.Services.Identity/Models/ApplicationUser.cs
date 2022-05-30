using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UsersAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int idUsuario { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public string RFC { get; set; } = string.Empty;
    }
}
