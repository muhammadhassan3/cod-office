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
using RestSharp;

namespace COD_Market_Office.Page.User
{
    /// <summary>
    /// Interaction logic for AddEditKaryawan.xaml
    /// </summary>
    public partial class AddEditKaryawan : Window
    {
        private string name;
        private Model.Outlet.Outlet outlet;
        public AddEditKaryawan(Window owner, Model.Outlet.Outlet outlet, UserKaryawan user)
        {
            InitializeComponent();
            this.Owner = owner;
            this.outlet = outlet;
            if(user != null)
            {
                tbTelp.Text = user.owner.telp;
                name = user.owner.nama;
                lblName.Content = user.owner.nama;
            }
        }

        private void LoadGrant()
        {
            List<Grant.MdlGrant> grantList = new List<Grant.MdlGrant>();

            //Identify user Grant for ComboBox
            if(ApiRequest.user.jabatan == Grant.Type.ADMINISTRATOR)
            {
                List<Grant.Type> typeList = Enum.GetValues(typeof(Grant.Type)).Cast<Grant.Type>().ToList();
                foreach(Grant.Type type in typeList)
                {
                    grantList.Add(new Grant.MdlGrant(Grant.GetName(type), type));
                }
            }
            else
            {
                Grant.Type[] grants = { Grant.Type.KEPALA_TOKO, Grant.Type.KURIR, Grant.Type.KEUANGAN, Grant.Type.KASIR_COD, Grant.Type.KASIR_TOKO, Grant.Type.SHOP_ITEM_INPUTER };
                foreach (Grant.Type type in grants)
                {
                    grantList.Add(new Grant.MdlGrant(Grant.GetName(type), type));
                }
            }
            cbGrant.DisplayMemberPath = "name";
            cbGrant.ItemsSource = grantList;
        }

        private void OnVerifyClicked(object obj, RoutedEventArgs args)
        {
            string phone = tbTelp.Text.Trim();
            if (!String.IsNullOrEmpty(phone))
            {
                var response = ApiRequest.VerifyUser(phone);
                if (response.Data.status)
                {
                    if (response.Data.status)
                    {
                        lblName.Content = response.Data.value;
                    }
                    else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            } else Dispatcher.BeginInvoke(new Action(() => MessageBox.Show("Harap isi nomor telepon terlebih dahulu", "Pemberitahuan", MessageBoxButton.OK, MessageBoxImage.Error)));
        }

        private void OnBtnSaveClicked(object obj, RoutedEventArgs artgs)
        {
            if (String.IsNullOrEmpty(name))
            {
                string phone = tbTelp.Text.Trim();
                List<long> outletList = new List<long>();
                outletList.Add(outlet.id);
                Grant.MdlGrant grant = (Grant.MdlGrant)cbGrant.SelectedItem;
                IRestResponse<Feedback<object>> response = ApiRequest.SaveUserKaryawan(phone, (Grant.Type)grant.type,outletList);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        this.Close();
                        this.DialogResult = true;
                    }
                    else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            }
            else Dispatcher.BeginInvoke(new Action(() => MessageBox.Show("Harap Verifikasi nomor telepon tersebut terlebih dahulu", "Pemberitahuan")));
        }
    }
}
