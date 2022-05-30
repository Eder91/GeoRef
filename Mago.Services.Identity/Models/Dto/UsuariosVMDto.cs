using Microsoft.AspNetCore.Mvc.Rendering;

namespace UsersAPI.Models.Dto
{
    public class UsuariosVMDto
    {
        public IEnumerable<SelectListItem?>? TypeDropDown { get; set; }
    }
}
