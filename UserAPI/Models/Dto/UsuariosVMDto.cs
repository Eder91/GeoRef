using Microsoft.AspNetCore.Mvc.Rendering;

namespace UserAPI.Models.Dto
{
    public class UsuariosVMDto
    {
        public IEnumerable<SelectListItem?>? TypeDropDown { get; set; }
    }
}
