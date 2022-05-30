using Microsoft.AspNetCore.Mvc.Rendering;

namespace GeoReferenceAPI.Models.Dto
{
    public class GeoReferenceVM
    {
        public virtual IEnumerable<SelectListItem?>? TypeDropDown { get; set; }
    }
}
