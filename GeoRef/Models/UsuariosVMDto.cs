using Microsoft.AspNetCore.Mvc.Rendering;

namespace GeoRef.Models
{
    public class UsuariosVMDto
    {
        public IEnumerable<SelectListItem?>? TypeDropDown { get; set; }
    }
}
