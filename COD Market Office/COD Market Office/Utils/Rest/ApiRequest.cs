using COD_Market_Office.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using COD_Market_Office.Model.Jasa;
using System.IO;
using COD_Market_Office.Model.Outlet;
using COD_Market_Office.Model.Order;
using COD_Market_Office.Model.ItemList;
using COD_Market_Office.Model.Stock;

namespace COD_Market_Office.Utils.Rest
{
    class ApiRequest
    {
        const string dev = "http://localhost";
        const string release = "http://202.83.120.237";
        const string beta = "http://202.83.120.237:82";
        public const string BaseUrl = release;
        public static string username { get; set; }
        public static string password { get; set; }
        public static UserKaryawan user { get; set; }

        private static RestClient init()
        {
            var RestClient = new RestClient(BaseUrl);
            if(username != null && password != null)
            {
                RestClient.Authenticator = new HttpBasicAuthenticator(username, password);
            }
            return RestClient;
        }

        public static IRestResponse<Feedback<UserKaryawan>> Login(string username,string password)
        {
            var RestClient = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/karyawan/login";
            request.AddParameter("username", username);
            request.AddParameter("pass", password);
            var response = RestClient.ExecuteAsync<Feedback<UserKaryawan>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<string>> Encrypt(string text)
        {
            Console.WriteLine("Encrypting...");
            var RestClient = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/encrypt";
            request.AddParameter("text", text);
            var response = RestClient.ExecuteAsync<Feedback<string>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<Kategori>>> GetKategoriJasa()
        {
            Console.WriteLine("Request Kategori Jasa");
            var RestClient = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/jasa/all";
            var response = RestClient.ExecuteAsync<Feedback<List<Kategori>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<ItemJasa>>> getItemJasa(long katId)
        {
            Console.WriteLine("Request Item Jasa");
            var RestClient = init();
            var request = new RestRequest(Method.GET);
            request.AddParameter("kat", katId,ParameterType.UrlSegment);
            request.Resource = "/api/v1/jasa/all/{kat}";
            var response = RestClient.ExecuteAsync<Feedback<List<ItemJasa>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<object>> savekatJasa(string katName, bool isVisible, string filePath)
        {
            Console.WriteLine("Saving Kategori Jasa");
            var RestClient = init();
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("nama", katName);
            request.AddParameter("visible", isVisible);
            request.AddFile("file\"; filename=\"image\" ",filePath);
            request.Resource = "/api/v1/jasa/save";
            var response = RestClient.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<object>> editKatJasa(long id, string katName, bool isVisible, String filePath)
        {
            Console.WriteLine("Editing Kategori Jasa");
            var client = init();
            var request = new RestRequest(Method.PUT);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("id", id);
            request.AddParameter("nama", katName);
            request.AddParameter("visible", isVisible);
            if (filePath != null) request.AddFile("file\";filename=\"image\"", filePath);
            request.Resource = "/api/v1/jasa/edit";
            var response = client.ExecuteAsync<Feedback<object>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<InvoiceJasa>>> GetUnVerifiedInvoiceJasa()
        {
            Console.WriteLine("Load Invoice Jasa");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/invoice/jasa";
            var response = client.ExecuteAsync<Feedback<List<InvoiceJasa>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<InvoiceJasa>>> GetAllInvoiceJasa()
        {
            Console.WriteLine("Load Invoice Jasa");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/invoice/jasa/all";
            var response = client.ExecuteAsync<Feedback<List<InvoiceJasa>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<object>> ApproveInvoice(long invoiceId)
        {
            Console.WriteLine("Validate Invoice");
            var client = init();
            var request = new RestRequest(Method.PUT);
            request.Resource = "/api/v1/invoice/jasa/approve";
            request.AddParameter("id", invoiceId);
            var response = client.ExecuteAsync<Feedback<object>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<object>> DenyInvoice(string invoiceNumber)
        {
            Console.WriteLine("Denying Invoice");
            var client = init();
            var request = new RestRequest(Method.PUT);
            request.Resource = "/api/v1/invoice/jasa/deny";
            request.AddParameter("nomor", invoiceNumber);
            var response = client.ExecuteAsync<Feedback<object>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<Model.Outlet.Outlet>>> GetOutlet()
        {
            Console.WriteLine("Get Outlet");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/wh/all";
            var response = client.ExecuteAsync<Feedback<List<Outlet>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<OutletInvoice>>> getInvoiceOutlet()
        {
            Console.WriteLine("Get Outlet Invoice");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/invoice/outlet/";
            var response = client.ExecuteAsync<Feedback<List<OutletInvoice>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<Area>>> getProv()
        {
            Console.WriteLine("Get Provinsi");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/area/";
            var response = client.ExecuteAsync<Feedback<List<Area>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<Area>>> getKab(long provId)
        {

            Console.WriteLine("Get Kab");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/area/{provId}";
            request.AddParameter("provId", provId, ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<List<Area>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<object>> saveOutlet(string nama, string alamat, string email, string telp, double latitude, double longitude, long kabId, long provId, bool isShop, bool isVisible, bool isOpen)
        {
            Console.WriteLine("Saving Outlet");
            var client = init();
            var request = new RestRequest(Method.POST);
            request.Resource = "/api/v1/wh/save";
            request.AddParameter("nama", nama);
            request.AddParameter("alamat", alamat);
            request.AddParameter("email", email);
            request.AddParameter("kab", kabId);
            request.AddParameter("prov", provId);
            request.AddParameter("lat", latitude);
            request.AddParameter("long", longitude);
            request.AddParameter("telp", telp);
            request.AddParameter("shop", isShop);
            request.AddParameter("open", isOpen);
            request.AddParameter("visible", isVisible);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<object>> editOutlet(long outletId,string nama, string alamat, string email, string telp, double latitude, double longitude, long kabId, long provId, bool isShop, bool isVisible, bool isOpen)
        {
            Console.WriteLine("Saving Outlet");
            var client = init();
            var request = new RestRequest(Method.POST);
            request.Resource = "/api/v1/wh/save";
            request.AddParameter("id", outletId);
            request.AddParameter("nama", nama);
            request.AddParameter("alamat", alamat);
            request.AddParameter("email", email);
            request.AddParameter("kab", kabId);
            request.AddParameter("prov", provId);
            request.AddParameter("lat", latitude);
            request.AddParameter("long", longitude);
            request.AddParameter("telp", telp);
            request.AddParameter("shop", isShop);
            request.AddParameter("open", isOpen);
            request.AddParameter("visible", isVisible);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<List<MdlOrderkat>>> GetOrder(int status, long outletId)
        {
            Console.WriteLine($"Getting Order With Status {status}");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v2/order/{wh}";
            request.AddParameter("wh", outletId, ParameterType.UrlSegment);
            request.AddParameter("status", status);
            var response = client.ExecuteAsync<Feedback<List<MdlOrderkat>>>(request).GetAwaiter().GetResult();
            return response;
        }


        public static IRestResponse<Feedback<MdlOrderItem>> GetOrderItem(long outletId, long katId)
        {
            Console.WriteLine($"Get Order Item with id: {katId}");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/order/{wh}/{kat}";
            request.AddParameter("wh", outletId, ParameterType.UrlSegment);
            request.AddParameter("kat", katId, ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<MdlOrderItem>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<User>>> getKurir(long outletId)
        {
            Console.WriteLine("Getting Courier...");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/karyawan/{wh}/{jabatan}";
            request.AddParameter("wh", outletId, ParameterType.UrlSegment);
            request.AddParameter("jabatan", "KURIR", ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<List<User>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<object>> UpdateOrder(long orderId, int status)
        {
            Console.WriteLine("Updating Status");
            var client = init();
            var request = new RestRequest(Method.PUT);
            request.Resource = "/api/v1/order/update";
            request.AddParameter("id", orderId);
            request.AddParameter("before", status);
            var response = client.ExecuteAsync<Feedback<object>>(request).GetAwaiter().GetResult();
            return response;

        }

        public static IRestResponse<Feedback<object>> SetCourier(long courierId, List<long> orderIdList)
        {
            Console.WriteLine("Send Order to Courier");
            var client = init();
            var request = new RestRequest(Method.POST);
            request.Resource = "/api/v1/order/setKurir";
            request.AddParameter("kurir", courierId);
            request.AddParameter("order", orderIdList);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<object>> setFinish(long orderId)
        {
            var client = init();
            var request = new RestRequest(Method.PUT);
            request.Resource = "/api/v1/process/setSelesai";
            request.AddParameter("id", orderId);
            request.AddParameter("status", "TERKIRIM");
            var response = client.ExecuteAsync<Feedback<object>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<User>>> getUserList(string grant)
        {
            Console.WriteLine("Get User List");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v2/user/all";
            request.AddParameter("grant", grant);
            var response = client.ExecuteAsync<Feedback<List<User>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<object>> EditUserProfile(long userId, string name, string alamat, string username, bool enabled)
        {
            Console.WriteLine("Editing User");
            var client = init();
            var request = new RestRequest(Method.PUT);
            request.Resource = "/api/v1/user/edit";
            request.AddParameter("id", userId);
            request.AddParameter("name", name);
            request.AddParameter("alamat", alamat);
            request.AddParameter("username", username);
            request.AddParameter("enabled", enabled);
            var response = client.ExecuteAsync<Feedback<object>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<UserKaryawan>>> GetKaryawanList(long outletId)
        {
            Console.WriteLine("Getting Karyawan");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/karyawan/{wh}";
            request.AddParameter("wh", outletId, ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<List<UserKaryawan>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<string>> VerifyUser(string phone)
        {
            Console.WriteLine("Verify User Phone Number");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/karyawan/cek/{phone}";
            request.AddParameter("phone", phone, ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<string>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<object>> SaveUserKaryawan(string phone, Grant.Type type, List<long> outletId)
        {
            Console.WriteLine("Saving User Karyawan");
            var client = init();
            var request = new RestRequest(Method.POST);
            request.Resource = "/api/v1/karyawan/save";
            request.AddParameter("telp", phone);
            request.AddParameter("jabatan", type);
            request.AddParameter("wh", outletId);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<List<MdlItem>>> GetKatStock(long outletId)
        {
            Console.WriteLine("Getting Kategori Stock List");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "v1/stock/all/{wh}";
            request.AddParameter("wh", outletId, ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<List<MdlItem>>>(request).GetAwaiter().GetResult();
            return response;
        }
        public static IRestResponse<Feedback<List<MdlItem>>> GetMerekStock(long outletId, long katId)
        {
            Console.WriteLine("Getting Merek Stock List");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "v1/stock/all/{wh}/{kat}";
            request.AddParameter("wh", outletId, ParameterType.UrlSegment);
            request.AddParameter("kat", katId, ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<List<MdlItem>>>(request).GetAwaiter().GetResult();
            return response;
        }
        public static IRestResponse<Feedback<List<Stock>>> GetItemStock(long outletId, long katId, long merekId)
        {
            Console.WriteLine("Getting Item Stock List");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "v1/stock/all/{wh}/{kat}/{merek}";
            request.AddParameter("wh", outletId, ParameterType.UrlSegment);
            request.AddParameter("kat", katId, ParameterType.UrlSegment);
            request.AddParameter("merek", merekId, ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<List<Stock>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<BarcodeSearch>>> FindItemByBarcode(string barcode)
        {
            Console.WriteLine($"Finding item with query: {barcode}");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "v1/list/search/barcode/{query}";
            request.AddParameter("query", barcode, ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<List<BarcodeSearch>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<object>> StockIn(long itemId, long outletId, long stok, long harga, long fee, long diskon, long minGrosir,long diskonGrosir, bool grosir)
        {
            Console.WriteLine("Saving stock in.....");
            var client = init();
            var request = new RestRequest(Method.POST);
            request.Resource = "v1/stockin/save";
            request.AddParameter("id",itemId);
            request.AddParameter("wh", outletId);
            request.AddParameter("stok", stok);
            request.AddParameter("harga", harga);
            request.AddParameter("fee", fee);
            request.AddParameter("diskon", diskon);
            request.AddParameter("min", minGrosir);
            request.AddParameter("diskon-grosir", diskonGrosir);
            request.AddParameter("grosir", grosir);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<object>> EditStock(long itemId, long outletId, int stock)
        {
            Console.WriteLine("Editing Stock..");
            var client = init();
            var request = new RestRequest(Method.PUT);
            request.Resource = "/api/v1/stock/{outlet}/edit";
            request.AddParameter("outlet", outletId, ParameterType.UrlSegment);
            request.AddParameter("item", itemId);
            request.AddParameter("stock", stock);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<List<MdlItem>>> getKategoriProductList()
        {
            Console.WriteLine("Load Kategori List Product");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/list/all";
            var response = client.ExecuteAsync<Feedback<List<MdlItem>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<MdlItem>>> getMerekProductList(long katId)
        {
            Console.WriteLine($"Load Merek List Product With KatId({katId})");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/list/all/{katId}";
            request.AddParameter("katId", katId, ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<List<MdlItem>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<MdlItem>>> getItemProductList(long katId, long merekId)
        {
            Console.WriteLine($"Load Item List Product With KatId({katId}) and merekId({merekId})");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/list/all/{katId}/{merekId}/";
            request.AddParameter("katId", katId, ParameterType.UrlSegment);
            request.AddParameter("merekId", merekId, ParameterType.UrlSegment);
            var response = client.ExecuteAsync<Feedback<List<MdlItem>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<List<MdlItem>>> getAllMerekList()
        {
            Console.WriteLine("Load All Merek List...");
            var client = init();
            var request = new RestRequest(Method.GET);
            request.Resource = "/api/v1/list/merek/all";
            var response = client.ExecuteAsync<Feedback<List<MdlItem>>>(request).GetAwaiter().GetResult();
            return response;
        }

        public static IRestResponse<Feedback<object>> saveKategoriProduct(string name, bool visible)
        {
            Console.WriteLine("Saving Kategori....");
            var client = init();
            var request = new RestRequest(Method.POST);
            request.Resource = "/api/v1/list/kat/save";
            request.AddParameter("nama", name);
            request.AddParameter("visible", visible);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }
        public static IRestResponse<Feedback<object>> editKategoriProduct(long id, string name, bool visible)
        {
            Console.WriteLine("Saving Kategori....");
            var client = init();
            var request = new RestRequest(Method.PUT);
            request.Resource = "/api/v1/list/kat/edit";
            request.AddParameter("id", id);
            request.AddParameter("nama", name);
            request.AddParameter("visible", visible);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<object>> saveMerekProduct(string name, string filePath,bool visible)
        {
            var client = init();
            var request = new RestRequest(Method.POST);
            request.Resource = "/api/v1/list/merek/save";
            request.AddFile("file\"; filename=\"image\" ", filePath);
            request.AddParameter("nama", name);
            request.AddParameter("visible", visible);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }
        public static IRestResponse<Feedback<object>> editMerekProduct(long id, string name, string filePath, bool visible)
        {
            var client = init();
            var request = new RestRequest(Method.POST);
            request.Resource = "/api/v1/list/merek/edit";
            request.AddFile("file\"; filename=\"image\" ", filePath);
            request.AddParameter("nama", name);
            request.AddParameter("id", id);
            request.AddParameter("visible", visible);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<object>> addMerekProduct(long katId,long merekId)
        {
            var client = init();
            var request = new RestRequest(Method.PUT);
            request.Resource = "/api/v1/list/merek/add";
            request.AddParameter("mer", merekId);
            request.AddParameter("kat", katId);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<object>> saveItemProduct(long katId, long merekId, string name, string barcode, double ppn, bool visible, string filePath)
        {
            var client = init();
            var request = new RestRequest(Method.POST);
            request.Resource = "/api/v1/list/item/save";
            request.AddFile("file\"; filename=\"image\"", filePath);
            request.AddParameter("kat", katId);
            request.AddParameter("mer", merekId);
            request.AddParameter("nama", name);
            request.AddParameter("barcode", barcode);
            request.AddParameter("ppn", ppn);
            request.AddParameter("visible", visible);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }

        public static IRestResponse<Feedback<object>> editItemProduct(long id, string name, bool visible, string filePath, double ppn, string barcode)
        {
            var client = init();
            var request = new RestRequest(Method.PUT);
            request.Resource = "/api/v1/list/item/edit";
            request.AddFile("file\";filename=\"image\"", filePath);
            request.AddParameter("id", id);
            request.AddParameter("nama", name);
            request.AddParameter("visible", visible);
            request.AddParameter("barcode", barcode);
            request.AddParameter("ppn", ppn);
            var response = client.Execute<Feedback<object>>(request);
            return response;
        }
    }
}
