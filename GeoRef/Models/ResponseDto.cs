namespace GeoRef.Models
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; } = null;
        public string DisplayName { get; set; } = "";
        public List<string> ErrorMessages { get; set; }
    }
}
