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
using System.Windows.Navigation;
using System.Windows.Shapes;
using COD_Market_Office.Model;
using COD_Market_Office.Utils.Rest;

namespace COD_Market_Office.Page.User
{
    /// <summary>
    /// Interaction logic for ListUserKaryawan.xaml
    /// </summary>
    public partial class ListUserKaryawan : UserControl
    {
        private List<UserKaryawan> list { get; set; }
        public ListUserKaryawan()
        {
            InitializeComponent();
            loadOutlet();
            loadGrant();
        }

        private void BtnBackClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new Home());
        }

        private void loadOutlet()
        {
            var response = ApiRequest.GetOutlet();
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    cbOutlet.ItemsSource = response.Data.errorMessage;
                    cbOutlet.DisplayMemberPath = "nama";
                    cbOutlet.SelectedIndex = 0;
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else Utils.Utils.setFailedRequest(response.StatusCode);
        }

        private void loadGrant()
        {
            List<Grant.MdlGrant> grants = new List<Grant.MdlGrant>();
            grants.Add(new Grant.MdlGrant("Semua",null));
            List<Grant.Type> list = Enum.GetValues(typeof(Grant.Type)).Cast<Grant.Type>().ToList();
            foreach(Grant.Type type in list)
            {
                grants.Add(new Grant.MdlGrant(Grant.GetName(type), type));
            }
            cbFilter.ItemsSource = grants;
            cbFilter.DisplayMemberPath = "name";
        }

        private void BtnSearchClicked(object obj, RoutedEventArgs args)
        {
            List<UserKaryawan> userList = (List<UserKaryawan>)tblUser.ItemsSource;
            string query = tbSearch.Text.Trim();
            List<UserKaryawan> filterResult = new List<UserKaryawan>();
            foreach (UserKaryawan user in userList)
            {
                if(user.owner.nama.ToLower().Equals(query.ToLower()) || user.owner.telp.ToLower().Equals(query.ToLower()))
                {
                    filterResult.Add(user);
                }
            }
            tblUser.ItemsSource = filterResult;
        }

        private void OnFilterChanged(object obj, SelectionChangedEventArgs args)
        {
            if(cbFilter.SelectedIndex == 0)
            {
                LoadUserItem();
            }
            else
            {
                Grant.MdlGrant filter = (Grant.MdlGrant)cbFilter.SelectedItem;
                List<UserKaryawan> data = (List<UserKaryawan>)tblUser.ItemsSource;
                List<UserKaryawan> result = new List<UserKaryawan>();
                foreach(UserKaryawan user in data)
                {
                    if(filter.type.GetType() == typeof(Grant.Type))
                    {
                        Grant.Type type = (Grant.Type)filter.type;
                        if (user.jabatan == type)
                        {
                            result.Add(user);
                        }
                    }
                }
                tblUser.ItemsSource = result;
            }
        }

        private void LoadUserItem()
        {
            Model.Outlet.Outlet outlet = (Model.Outlet.Outlet)cbOutlet.SelectedItem;
            var response = ApiRequest.GetKaryawanList(outlet.id);
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    tblUser.ItemsSource = response.Data.value;
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else Utils.Utils.setFailedRequest(response.StatusCode);
        }

        private void OnOutletSelectionChanged(object obj, SelectionChangedEventArgs args)
        {
            cbFilter.SelectedIndex = 0;
            LoadUserItem();
        }

        private void OnAddClicked(object obj, RoutedEventArgs args)
        {
            Model.Outlet.Outlet outlet = (Model.Outlet.Outlet)cbOutlet.SelectedItem;
            AddEditKaryawan add = new AddEditKaryawan((Window)this.Parent, outlet, null);
            add.ShowDialog();
            if(add.DialogResult == true)
            {
                cbFilter.SelectedIndex = 0;
                LoadUserItem();
            }
        }

        private void OnEditClicked(object obj, RoutedEventArgs args)
        {
            Model.Outlet.Outlet outlet = (Model.Outlet.Outlet)cbOutlet.SelectedItem;
            UserKaryawan user = (UserKaryawan)tblUser.SelectedItem;
            AddEditKaryawan add = new AddEditKaryawan((Window)this.Parent, outlet, user);
            add.ShowDialog();
            if (add.DialogResult == true)
            {
                cbFilter.SelectedIndex = 0;
                LoadUserItem();
            }
        }
    }
}
