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
using COD_Market_Office.Model;
using COD_Market_Office.Utils.Rest;

namespace COD_Market_Office.Page.User
{
    /// <summary>
    /// Interaction logic for AddEditUser.xaml
    /// </summary>
    public partial class AddEditUser : Window
    {
        private Model.User user { get; set; }
        public AddEditUser(Window parent, Model.User user)
        {
            InitializeComponent();
            this.Owner = parent;
            this.user = user;
            LoadProvince();
        }

        private void OnProviceSelectionChanged(object obj, SelectionChangedEventArgs args)
        {
            if (cbProv.SelectedIndex > 0)
            {
                Area province = (Area)cbProv.SelectedItem;
                LoadKab(province.id);
            }
        }
        private bool isProvAndKabSelected()
        {
            return cbProv.SelectedIndex > 0 && cbKab.SelectedIndex > 0;
        }
        private void LoadProvince()
        {
            var response = ApiRequest.getProv();
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    cbProv.DisplayMemberPath = "nama";
                    cbProv.ItemsSource = response.Data.value;
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }
        private void LoadKab(long provinceId)
        {

        }

        private void BtnSaveClicked(object obj, RoutedEventArgs args)
        {
            if (isProvAndKabSelected() && !String.IsNullOrEmpty(tbNama.Text) && !String.IsNullOrEmpty(tbAlamat.Text) && !String.IsNullOrEmpty(tbTelp.Text) && !String.IsNullOrEmpty(tbRt.Text) && !String.IsNullOrEmpty(tbRw.Text))
            {
                Area kab = (Area)cbKab.SelectedItem;
                Area prov = (Area)cbProv.SelectedItem;
                var alamat = $"{tbAlamat.Text} Rt. {tbRt.Text}  Rw. {tbRw.Text}, Kelurahan {tbKelurahan.Text}, Kecamatan {tbKec.Text}, Kabupaten {kab.nama}, Provinsi {prov.nama}";
                var response = ApiRequest.EditUserProfile(user.id, tbNama.Text,alamat,tbTelp.Text, (bool)!cbBlocked.IsChecked);
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
            } else Dispatcher.BeginInvoke(new Action(() => MessageBox.Show("Harap Lengkapi data yang diperlukan", "Pemberitahuan", MessageBoxButton.OK, MessageBoxImage.Error)));
        }
    }
}
