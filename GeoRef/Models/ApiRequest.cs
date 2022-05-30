﻿using static GeoRef.SD;

namespace GeoRef.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; } = string.Empty;
        public object Data { get; set; } = null;
        public string AccessToken { get; set; } = string.Empty;
    }
}
