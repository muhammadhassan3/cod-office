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
using Microsoft.Win32;

namespace COD_Market_Office.Page.Item
{
    /// <summary>
    /// Interaction logic for AddEditItem.xaml
    /// </summary>
    public partial class AddEditItem : Window
    {
        private MdlItem category, merek, item;
        private Uri fileUri;
        public AddEditItem(Window owner,MdlItem category, MdlItem merek, MdlItem item)
        {
            InitializeComponent();
            this.Owner = owner;
            this.category = category;
            this.merek = merek;
            lblKat.Content = category.nama;
            lblMerek.Content = merek.nama;
            if(item == null)
            {
                this.Title = "Tambahkan Item";
            }
            else
            {
                this.Title = "Ubah Item";
                this.item = item;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                string url = ApiRequest.BaseUrl + "/api/v1/list/item/image/" + item.id;
                bitmap.UriSource = new Uri(url, UriKind.RelativeOrAbsolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                image.Source = bitmap;
                tbBarcode.Text = item.barcode;
                tbName.Text = item.nama;
                tbPPN.Text = item.ppn.ToString();
                cbVisible.IsChecked = item.visible;
            }
        }

        private void btnSelectClicked(object obj, RoutedEventArgs args)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg)| *.jpg;*.jpeg;";
            if(dialog.ShowDialog() == true)
            {
                fileUri = new Uri(dialog.FileName);
                image.Source = new BitmapImage(fileUri);
                lblSize.Content = $"Size: {Utils.Utils.getFileSize(fileUri.LocalPath)}";
            }
        }

        private void btnSaveClicked(object obj, RoutedEventArgs args)
        {
            string name = tbName.Text.Trim(),
                barcode = tbBarcode.Text.Trim();
            double ppn = Double.Parse(tbPPN.Text.Trim());
            bool visible = (bool)cbVisible.IsChecked;
            if(!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(barcode))
            {
                var response = item == null ? ApiRequest.saveItemProduct(category.id, merek.id, name, barcode, ppn, visible, fileUri?.LocalPath)
                    : ApiRequest.editItemProduct(item.id, name, visible, fileUri?.LocalPath, ppn, barcode);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        this.DialogResult = true;
                        this.Close();
                    }
                    else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }
    }
}
