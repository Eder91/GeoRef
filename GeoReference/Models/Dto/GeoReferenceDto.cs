using Microsoft.AspNetCore.Mvc.Rendering;

namespace GeoReferenceAPI.Models.Dto
{
    public class GeoReferenceDto
    {
        public int idGeoreferencia { get; set; }
        public int idEstado { get; set; }
        public virtual EstadosDto? Estados { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
