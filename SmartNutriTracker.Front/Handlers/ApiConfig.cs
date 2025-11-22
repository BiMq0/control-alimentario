using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartNutriTracker.Front.Handlers
{
    public static class ApiConfig
    {
        /// <summary>
        /// URL del API HTTP, no recomendado para probar cookies, levantar servidor backend en HTTPs.  
        /// </summary>
        /// <sample>dotnet run # Por defecto se usa HTTP</sample>
        public static string HttpApiUrl { get; } = "http://localhost:5073/";

        /// <summary>
        /// URL del API HTTPS, recomendado para producción y pruebas con cookies.
        /// </summary>
        /// <sample>dotnet run --launch-profile https</sample>
        public static string HttpsApiUrl { get; } = "https://localhost:7187/";
    }
}