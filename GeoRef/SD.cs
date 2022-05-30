namespace GeoRef
{
    public static class SD
    {
        public static string UserAPIBase { get; set; }
        public static string EstadoAPIBase { get; set; }
        public static string GeoReferenceAPIBase { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
