using COD_Market_Office.Utils.Rest;
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

namespace COD_Market_Office.Page.Stock
{
    /// <summary>
    /// Interaction logic for EditStock.xaml
    /// </summary>
    public partial class EditStock : Window
    {
        public Model.Stock.Stock stock { get; set; }
        public Model.Outlet.Outlet outlet { get; set; }
        public EditStock(Window owner, Model.Stock.Stock stock, Model.Outlet.Outlet outlet)
        {
            InitializeComponent();
            this.Owner = owner;
            this.stock = stock;
            this.outlet = outlet;
            string v = ApiRequest.BaseUrl + "/api/v1/list/item/image/" + stock.item.id;
            BitmapImage BitmapImage = new BitmapImage();
            BitmapImage.BeginInit();
            BitmapImage.UriSource = new Uri(v, UriKind.RelativeOrAbsolute);
            BitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            BitmapImage.EndInit();
            imgItem.Source = BitmapImage;
            tbStock.Text = stock.stock.ToString();
            tbName.Content = stock.item.nama;
            tbGrocery.Content = stock.hargaJual - stock.grosirDiskon;
            tbRetailPrice.Content = stock.hargaJual;
        }

        private void OnBtnSaveClicked(object obj, RoutedEventArgs args)
        {
            int stock = int.Parse(tbStock.Text ?? "0");
            var response = ApiRequest.EditStock(this.stock.item.id, outlet.id, stock);
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    this.DialogResult = true;
                    Close();
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

    }
}
