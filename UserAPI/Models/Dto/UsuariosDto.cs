using Microsoft.AspNetCore.Mvc.Rendering;

namespace UserAPI.Models.Dto
{
    public class UsuariosDto
    {
        public int idUsuario { get; set; } = 0;
        public string Password { get; set; } = "abcde";
        public string Nombre { get; set; } = string.Empty;
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public string RFC { get; set; } = string.Empty;
    }
}
