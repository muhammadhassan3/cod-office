using COD_Market_Office.Model;
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
using RestSharp;

namespace COD_Market_Office.Page.Jasa
{
    /// <summary>
    /// Interaction logic for EditKatJasa.xaml
    /// </summary>
    public partial class EditKatJasa : Window
    {
        public Kategori Editedkategori { get; set; }
        private Uri fileUri;
        public EditKatJasa(Window owner, Kategori kategori)
        {
            InitializeComponent();
            this.Owner = owner;
            Editedkategori = kategori;
            string v = ApiRequest.BaseUrl+"/api/v1/jasa/kat/image/"+Editedkategori.id;
            BitmapImage BitmapImage = new BitmapImage();
            BitmapImage.BeginInit();
            BitmapImage.UriSource = new Uri(v,UriKind.RelativeOrAbsolute);
            BitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            BitmapImage.EndInit();
            image.Source = BitmapImage;
            tbName.Text = Editedkategori.nama;
            cbVisible.IsChecked = Editedkategori.visible;

        }

        private void SelectImageFromFile(object obj, EventArgs args)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg;*.jpeg;";
            if (openFileDialog.ShowDialog() == true)
            {
                fileUri = new Uri(openFileDialog.FileName);
                image.Source = new BitmapImage(fileUri);
                fileSize.Content = "Size : " + Utils.Utils.getFileSize(fileUri.LocalPath)/1024+" Kb";
            }
        }

        private void OnBtnSaveClicked(object obj, EventArgs args)
        {
            string name = tbName.Text.Trim();
            bool visible = (bool)cbVisible.IsChecked;
            string path = fileUri == null ? null : fileUri.LocalPath;
            IRestResponse<Feedback<object>> response = ApiRequest.editKatJasa(Editedkategori.id,name, visible, path);
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    this.DialogResult = true;
                    this.Hide();
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else Utils.Utils.setFailedRequest(response.StatusCode);
        }
    }
}
