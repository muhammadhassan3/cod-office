using COD_Market_Office.Model;
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
using RestSharp;
using COD_Market_Office.Utils.Rest;

namespace COD_Market_Office.Page.Jasa
{
    /// <summary>
    /// Interaction logic for AddKatJasa.xaml
    /// </summary>
    public partial class AddKatJasa : Window
    {
        private Kategori kategori { get; set; }
        private Uri fileUri;
        public AddKatJasa(Window owner)
        {
            InitializeComponent();
            this.Owner = owner;
        }
        private void OnBtnSaveClicked(object obj, EventArgs args)
        {
            string name = tbName.Text.Trim();
            bool visible = (bool)cbVisible.IsChecked;
            IRestResponse<Feedback<object>> response = ApiRequest.savekatJasa(name,visible,fileUri.LocalPath);
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    this.DialogResult = true;
                    this.Hide();
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

        private void SelectImageFromFile(object obj, EventArgs args)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg;*.jpeg;";
            if (openFileDialog.ShowDialog() == true)
            {
                fileUri = new Uri(openFileDialog.FileName);
                image.Source = new BitmapImage(fileUri);
                fileSize.Content = "Size : " + Utils.Utils.getFileSize(fileUri.LocalPath)+" Kb";
            }
        }
    }
}
