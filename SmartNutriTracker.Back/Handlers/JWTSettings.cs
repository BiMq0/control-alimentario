using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartNutriTracker.Back.Handlers
{
    public class JWTSettings
    {
        public string? Key { get; set; }
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
    }
}