using COD_Market_Office.Model.ItemList;
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

namespace COD_Market_Office.Page.Item
{
    /// <summary>
    /// Interaction logic for ItemFinder.xaml
    /// </summary>
    public partial class ItemFinder : Window
    {
        public BarcodeSearch item { get; set; }
        public ItemFinder(Window owner)
        {
            InitializeComponent();
            this.Owner = owner;
        }

        private void BtnSearchClicked(object obj, RoutedEventArgs args)
        {
            string barcode = tbQuery.Text.Trim();
            if (!String.IsNullOrEmpty(barcode))
            {
                var response = ApiRequest.FindItemByBarcode(barcode);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        tblItem.ItemsSource = response.Data.value;
                    }
                    else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            }
            else MessageBox.Show("Harap masukan barcode terlebih dahulu", "Pemberitahuan", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BtnSaveClicked(object obj, RoutedEventArgs args)
        {
            BarcodeSearch item = (BarcodeSearch)tblItem.SelectedItem;
            if (item != null)
            {
                this.item = item;
                this.DialogResult = true;
                Close();
            }
            else MessageBox.Show("Harap pilih item terlebih dahulu", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
