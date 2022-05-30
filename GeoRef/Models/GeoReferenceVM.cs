using Microsoft.AspNetCore.Mvc.Rendering;

namespace GeoRef.Models
{
    public class GeoReferenceVM
    {
        public virtual IEnumerable<SelectListItem?>? TypeDropDown { get; set; }
    }
}
