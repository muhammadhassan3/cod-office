using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model
{
    public class User
    {
        [JsonProperty("id")]
        public long id { get; set; }
        [JsonProperty("nama")]
        public string nama { get; set; }
        [JsonProperty("telp")]
        public string telp { get; set; }
        [JsonProperty("alamat")]
        public string alamat { get; set; }
        [JsonProperty("latitude")]
        public double latitude { get; set; }
        [JsonProperty("longitude")]
        public double longitude { get; set; }

        public bool enabled { get; set; }
        public string isBlocked
        {
            get
            {
                return enabled ? "Tidak" : "Ya";
            }
        }
    }
}
