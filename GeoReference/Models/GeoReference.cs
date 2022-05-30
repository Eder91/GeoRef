using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeoReferenceAPI.Models
{
    public class GeoReference
    {
        [Key]
        public int idGeoreferencia { get; set; }
        public int idEstado { get; set; }
        [ForeignKey("idEstado")]
        public virtual Estados? Estados { get; set; }
        [Required]
        public double Latitud { get; set; }
        [Required]
        public double Longitud { get; set; }
    }
}
