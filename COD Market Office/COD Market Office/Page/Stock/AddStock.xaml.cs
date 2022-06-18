using COD_Market_Office.Model.ItemList;
using COD_Market_Office.Page.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using COD_Market_Office.Utils.Rest;

namespace COD_Market_Office.Page.Stock
{
    /// <summary>
    /// Interaction logic for AddStock.xaml
    /// </summary>
    public partial class AddStock : Window
    {
        private BarcodeSearch itemResult { get; set; }
        private Model.Outlet.Outlet outlet { get; set; }
        public AddStock(Window owner, Model.Outlet.Outlet outlet)
        {
            InitializeComponent();
            this.Owner = owner;
            this.outlet = outlet;
        }

        private void BtnChooseItemSelected(object obj, RoutedEventArgs args)
        {
            ItemFinder find = new ItemFinder((Window)this.Parent);
            find.ShowDialog();
            if (find.DialogResult == true)
            {
                itemResult = find.item;
                string v = ApiRequest.BaseUrl + "/api/v1/list/item/image/" + itemResult.item.id;
                BitmapImage BitmapImage = new BitmapImage();
                BitmapImage.BeginInit();
                BitmapImage.UriSource = new Uri(v, UriKind.RelativeOrAbsolute);
                BitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                BitmapImage.EndInit();
                imgItem.Source = BitmapImage;
            }
        }

        private void BtnVerifyClicked(object obj, RoutedEventArgs args)
        {
            string stok = tbStok.Text.Trim();
            string hargaBeli = tbHarga.Text.Trim();
            string marginRetail = tbKeuntungan.Text.Trim();
            string discount = tbDiskon.Text.Trim();
            string marginGrocery = tbKeuntunganGrosir.Text.Trim();
            bool isGroceryAvailable = cbGrosir.IsChecked.GetValueOrDefault();
            string minimunGrocery = tbMinGrosir.Text.Trim();
            if(itemResult == null)
            {
                MessageBox.Show("Pilih item terlebih dahulu", "Pemberitahuan");
                return;
            }
            if (Utils.Utils.isNumericInput(stok) && Utils.Utils.isNumericInput(hargaBeli) && Utils.Utils.isNumericInput(marginRetail) && Utils.Utils.isNumericInput(marginGrocery) && Utils.Utils.isNumericInput(discount) && Utils.Utils.isNumericInput(minimunGrocery))
            {
                
                long priceRetail = (long)(long.Parse(hargaBeli)+long.Parse(marginRetail)-long.Parse(discount)+(long.Parse(hargaBeli)*itemResult.item.ppn/100));
                long priceGrocery = (long)(long.Parse(hargaBeli) + long.Parse(marginGrocery) - long.Parse(discount) + (long.Parse(hargaBeli) * itemResult.item.ppn/100));
                string message = $"Harap periksa kembali input anda :\n" +
                    $"Nama item                 : {itemResult.item.nama}\n" +
                    $"Jumlah Stok               : {stok}\n" +
                    $"Harga Beli                : {Utils.Utils.convertToRupiah(hargaBeli)}\n" +
                    $"Keuntungan                : {Utils.Utils.convertToRupiah(marginRetail)}({long.Parse(marginRetail)/long.Parse(hargaBeli)*100}%)\n" +
                    $"Diskon                    : {Utils.Utils.convertToRupiah(discount)}({long.Parse(discount)/priceRetail*100}%) // ({long.Parse(discount)/priceGrocery}%)\n" +
                    $"Harga Jual Retail         : {Utils.Utils.convertToRupiah(priceRetail.ToString())}\n" +
                    $"Tersedia Grosir           : {(isGroceryAvailable?"Ya" : "Tidak")}\n" +
                    $"Minimal Pembelian Grosir  : {minimunGrocery}\n" +
                    $"Keuntungan Grosir         : {Utils.Utils.convertToRupiah(marginGrocery)}({long.Parse(marginGrocery)/long.Parse(hargaBeli)*100}%)\n" +
                    $"Harga Jual Grosir         : {Utils.Utils.convertToRupiah(priceGrocery.ToString())}\n";

                MessageBoxResult result = MessageBox.Show(message, "Konfirmasi", MessageBoxButton.OKCancel);
                if(result == MessageBoxResult.OK)
                {
                    var response = ApiRequest.StockIn(itemResult.item.id, outlet.id, long.Parse(stok), long.Parse(hargaBeli), long.Parse(marginRetail), long.Parse(discount), long.Parse(minimunGrocery), (priceRetail - priceGrocery), isGroceryAvailable);
                    if (response.IsSuccessful)
                    {
                        if (response.Data.status)
                        {
                            this.DialogResult = true;
                            Close();
                        }
                        else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                    }
                    else Utils.Utils.setFailedRequest(response.StatusCode);
                }
            }
            else MessageBox.Show("Input Tidak valid", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void CbGrosirChanged(object obj, RoutedEventArgs args)
        {
            tbKeuntunganGrosir.IsEnabled = (bool)cbGrosir.IsChecked;
            tbMinGrosir.IsEnabled = (bool)cbGrosir.IsChecked;
        }
    }
}
