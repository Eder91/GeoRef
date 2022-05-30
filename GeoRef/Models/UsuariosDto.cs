using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GeoRef.Models
{
    public class UsuariosDto
    {
        public int idUsuario { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;
        public string RFC { get; set; } = string.Empty;
    }
}
