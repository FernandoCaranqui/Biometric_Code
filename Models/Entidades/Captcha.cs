using System.Collections.Generic;
using Newtonsoft.Json;

namespace Biometrico.Models.DAO
{
    public class Captcha
    {
        public bool Success { get; set; }
        public string Challenge_ts { get; set; }
        public string hostname { get; set; }

        [JsonProperty("error-codes")]
        public List<string> errorCodes { get; set; }
    }
}