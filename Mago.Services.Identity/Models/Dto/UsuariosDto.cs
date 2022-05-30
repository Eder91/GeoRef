using Microsoft.AspNetCore.Mvc.Rendering;

namespace UsersAPI.Models.Dto
{
    public class UsuariosDto
    {
        public int idUsuario { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public string RFC { get; set; } = string.Empty;
    }
}
