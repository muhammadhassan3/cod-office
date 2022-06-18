using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model.Jasa
{
    class ItemJasa
    {
        public long id { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string telp { get; set; }
        public bool whatsapp { get; set; }
        public string text { get; set; }
        public int jmlImg { get; set; }
        public long viewLangganan { get; set; }
        public long viewFree { get; set; }
        public List<ImageList> image { get; set; }
        public User owner { get; set; }
        public List<PaketJasa> paket { get; set; }
        public bool valid { get; set; }
        public string kab { get; set; }
        public string prov { get; set; }
        public int jmlImgFree { get; set; }
        public bool enabled { get; set; }
        public bool visible { get; set; }
        public string expire { get; set; }
        public long jmlView { get; set; }
        public long jmlViewFree { get; set; }
        public Double latitude { get; set; }
        public Double longitude { get; set; }
        public long viewers { get; set; }
        public string packageList
        {
            get
            {
                string packageList = "";
                for(int i = 0; i < paket.Count; i++)
                {
                    packageList += paket[i].nama;
                    if (i < paket.Count - 1) packageList += ", ";
                }
                return packageList;
            }
        }

        public string isBlocked
        {
            get
            {
                return enabled ? "Tidak" : "Ya";
            }
        }
        public string isVisible
        {
            get
            {
                return visible ? "Ya" : "Tidak";
            }
        }
    }

    public class ImageList
    {
        [JsonProperty("namaFile")]
        public string fileName { get; set; }
        public bool view { get; set; }
    }
}
