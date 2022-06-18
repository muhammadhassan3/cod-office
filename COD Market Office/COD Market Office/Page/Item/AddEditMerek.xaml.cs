using COD_Market_Office.Model.ItemList;
using COD_Market_Office.Utils.Rest;
using Microsoft.Win32;
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

namespace COD_Market_Office.Page.Item
{
    /// <summary>
    /// Interaction logic for AddEditMerek.xaml
    /// </summary>
    public partial class AddEditMerek : Window
    {
        private MdlItem merek;
        private Uri fileUri;
        public AddEditMerek(Window owner, MdlItem merek)
        {
            InitializeComponent();
            if(merek != null)
            {
                this.Title = "Ubah Merek";
                this.merek = merek;
                tbName.Text = merek.nama;
                cbVisible.IsChecked = merek.visible;
                string url = ApiRequest.BaseUrl + "/api/v1/list/merek/image/" + merek.id;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(url, UriKind.RelativeOrAbsolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                image.Source = bitmap;
            }
            else
            {
                this.Title = "Tambahkan Merek";
            }
            this.Owner = owner;
        }

        private void btnSelectClicked(object obj, RoutedEventArgs args)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg;)| *.jpg; *.jpeg;";
            if(dialog.ShowDialog() == true)
            {
                fileUri = new Uri(dialog.FileName);
                image.Source = new BitmapImage(fileUri);
                lblSize.Content = $"Size : {Utils.Utils.getFileSize(fileUri.LocalPath)/1024} Kb";
            }
        }

        private void btnSaveClicked(object obj, RoutedEventArgs args)
        {
            var name = tbName.Text.Trim();
            var visible = cbVisible.IsChecked;
            if (!String.IsNullOrEmpty(name))
            {
                var response = merek != null ? ApiRequest.editMerekProduct(merek.id, name, fileUri?.LocalPath, (bool)visible)
                    : ApiRequest.saveMerekProduct(name, fileUri?.LocalPath, (bool)visible);
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
            else Utils.Utils.setErrorMessage("Harap lengkapi semua form");
        }
    }
}
