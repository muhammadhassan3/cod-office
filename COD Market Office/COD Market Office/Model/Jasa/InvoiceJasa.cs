using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model.Jasa
{
    class InvoiceJasa
    {
        public long id { get; set; }
        public User owner { get; set; }
        public string owner_name { get
            {
                return owner==null?"Kosong":owner.nama;
            } 
        }
        [JsonProperty("harga")]
        public string harga { get; set; }
        public string harga_format
        {
            get
            {
                if (harga != null)
                {
                    double harga2 = Double.Parse(harga);
                    return harga2.ToString("C0", CultureInfo.CreateSpecificCulture("id-ID"));
                }
                else return "Kosong";
            }
        }
        public string createdAt { get; set; }
        public string nomor { get; set; }
        public string foto { get; set; }
        public string isImageAvailable
        {
            get
            {
                return foto != null ?"Ya":"Tidak";
            }
        }
        public PaketJasa paket { get; set; }
        public string paket_name { 
            get 
            { 
                return paket==null?"Kosong":paket.nama;
            }
        }
        public ItemJasa item { get; set; }
        public string jasa_name
        {
            get
            {
                return item==null?"Kosong":item.nama;
            }
        }
        public string expired { get; set; }
        public bool ditolak { get; set; }
        public bool approve { get; set; }
        public string status
        {
            get
            {
                string status = null;
                if (approve)
                {
                    status = "Diverifikasi";
                }
                else if (ditolak)
                {
                    status = "Ditolak";
                }else if (foto == null)
                {
                    status = "Menunggu Bukti Pembayaran";
                }
                return status;
            }
        }
    }
}
