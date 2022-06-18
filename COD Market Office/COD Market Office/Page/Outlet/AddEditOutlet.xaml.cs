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
using COD_Market_Office.Model.Outlet;
using COD_Market_Office.Utils.Rest;
using RestSharp;
using ToastNotifications;
using ToastNotifications.Messages;

namespace COD_Market_Office.Page.Outlet
{
    /// <summary>
    /// Interaction logic for AddEditOutlet.xaml
    /// </summary>
    public partial class AddEditOutlet : Window
    {
        public Model.Outlet.Outlet outlet { get; set; }
        private const int ADD = 0, EDIT = 1;
        private int type = -1;
        private DependencyObject parent;
        private object p;

        public AddEditOutlet(Window parent, Model.Outlet.Outlet outlet)
        {
            this.Owner = parent;
            InitializeComponent();
            loadProv();
            if(outlet == null)
            {
                type = ADD;
                this.Title = "Tambah Outlet";
            }
            else
            {
                type = EDIT;
                tbName.Text = outlet.nama;
                tbEmail.Text = outlet.email;
                tbAlamat.Text = outlet.alamat;
                tbLat.Text = outlet.latitude.ToString();
                tbLong.Text = outlet.longitude.ToString();
                tbTelp.Text = outlet.telp;

                cbOpen.IsChecked = outlet.open;
                cbShop.IsChecked = outlet.shop;
                cbVisible.IsChecked = outlet.visible;
                this.Title = "Ubah Outlet";
            }

        }

        private void OnProvItemSelected(object obj, SelectionChangedEventArgs args)
        {
            Area prov = (Area)cbProv.SelectedItem;
            loadKab(prov.id);
        }

        private void loadProv()
        {
            var response = ApiRequest.getProv();
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    cbProv.DisplayMemberPath = "nama";
                    cbProv.SelectedValuePath = "id";
                    cbProv.ItemsSource = response.Data.value;
                }
                else
                {
                    Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
            }
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

        private void loadKab(long provId)
        {
            var response = ApiRequest.getKab(provId);
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    cbKab.DisplayMemberPath = "nama";
                    cbKab.SelectedValuePath = "id";
                    cbKab.ItemsSource = response.Data.value;
                }
                else
                {
                    Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
            }
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

        public AddEditOutlet(DependencyObject parent, object p)
        {
            this.parent = parent;
            this.p = p;
        }

        private void OnSaveClicked(object obj, RoutedEventArgs args)
        {
            string name = tbName.Text,
                address = tbAlamat.Text,
                email = tbEmail.Text,
                telp = tbTelp.Text,
                latitude = tbLat.Text,
                longitude = tbLong.Text.Trim();
            Area prov = (Area)cbProv.SelectedItem,
                kab = (Area)cbKab.SelectedItem;
            bool isShop = cbShop.IsChecked.GetValueOrDefault(),
                isVisible = cbVisible.IsChecked.GetValueOrDefault(),
                isOpen = cbOpen.IsChecked.GetValueOrDefault();
            Notifier notifier = Utils.Utils.initNotification();
            if (String.IsNullOrEmpty(name))
            {
                notifier.ShowWarning("Form nama tidak boleh kosong");
                return;
            }
            if (String.IsNullOrEmpty(address))
            {
                notifier.ShowWarning("Form alamat tidak boleh kosong");
                return;
            }
            if (String.IsNullOrEmpty(email))
            {
                notifier.ShowWarning("Form email tidak boleh kosong");
                return;
            }
            if (String.IsNullOrEmpty(telp))
            {
                notifier.ShowWarning("Form Nomor Telepon tidak boleh kosong");
                return;
            }
            if (String.IsNullOrEmpty(latitude))
            {
                notifier.ShowWarning("Form Latitude tidak boleh kosong");
                return;
            }
            if (String.IsNullOrEmpty(longitude))
            {
                notifier.ShowWarning("Form Longitude tidak boleh kosong");
                return;
            }
            if (prov == null)
            {
                notifier.ShowWarning("Form provinsi tidak boleh kosong");
                return;
            }
            if (kab == null)
            {
                notifier.ShowWarning("Form kabupaten tidak boleh kosong");
                return;
            }
            double lat = 0, lng = 0;
            try
            {
                lat = Double.Parse(latitude);
            }catch(Exception ex)
            {
                notifier.ShowError("Harap input koordinat latitude dengan angka");
                return;
            }

            try
            {
                lng = Double.Parse(longitude);
            }
            catch (Exception ex)
            {
                notifier.ShowError("Harap input koordinat longitude dengan angka");
                return;
            }
            IRestResponse<Feedback<object>> response;
            if (type == ADD)
            {
                response = ApiRequest.saveOutlet(name, address, email, telp, lat, lng, kab.id, prov.id, isShop, isVisible, isOpen);
            }
            else
            {
                response = ApiRequest.editOutlet(outlet.id, name, address, email, telp, lat, lng, kab.id, prov.id, isShop, isVisible, isOpen);
            }

            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    this.DialogResult = true;
                    this.Close();
                }
                else
                {
                    Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
            }
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }
    }
}
