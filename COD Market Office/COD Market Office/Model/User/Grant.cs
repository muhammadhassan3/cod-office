using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_Market_Office.Model
{
    public class Grant
    {
        public enum Type {
            ADMINISTRATOR,
            INPUTER,
            KASIR_TOKO,
            KASIR_COD,
            SUPERVISOR,
            HRD,
            KURIR,
            PACKER,
            CHECKER,
            SECURITY,
            KEPALA_TOKO,
            KEUANGAN,
            INVOICE_VALIDATOR,
            USER_MANAGEMENT,
            SHOP_ITEM_INPUTER,
            JASA_INPUTER,
            NOPEN_INPUTER
        }
        private static string[] Names = {
            "Administrator",
            "Inputer",
            "Kasir Toko Offline",
            "Kasir Toko Online",
            "Supervisor",
            "HRD",
            "Kurir",
            "Packer",
            "Checker",
            "Security",
            "Kepala Toko",
            "Akuntan",
            "Invoice Validator",
            "User Management",
            "Inputer Barang Toko",
            "Inputer Jasa",
            "Inputer Toko Penting"
        };
        public static string GetName(Type type)
        {
            int position = (int)type;
            return Names[position];
        }

        public static int GetSize()
        {
            return Names.Length;
        }

        public class MdlGrant
        {
            public string name { get; set; }
            public object type { get; set; }
            public MdlGrant(string name, object type)
            {
                this.name = name;
                this.type = type;
            }
        }
    }
}
