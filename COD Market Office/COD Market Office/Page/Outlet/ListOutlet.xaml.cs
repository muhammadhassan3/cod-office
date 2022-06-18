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
using RestSharp;
using COD_Market_Office.Model;
using COD_Market_Office.Model.Outlet;
using COD_Market_Office.Utils.Rest;
using ToastNotifications;
using ToastNotifications.Messages;
using ToastNotifications.Position;
using ToastNotifications.Lifetime;

namespace COD_Market_Office.Page.Outlet
{
    /// <summary>
    /// Interaction logic for ListOutlet.xaml
    /// </summary>
    public partial class ListOutlet : UserControl
    {
        private List<Model.Outlet.Outlet> outletList = new List<Model.Outlet.Outlet>();
        public ListOutlet()
        {
            InitializeComponent();
            loadTable();
        }

        private void loadTable()
        {
            var response = ApiRequest.GetOutlet();
            if (response.IsSuccessful )
            {
                if (response.Data.status)
                {
                    outletList = response.Data.value;
                    tblOutlet.ItemsSource = outletList;
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

        private void OnBackPressed(object obj, EventArgs args)
        {
            Switcher.Switch(new Home());
        }

        private void OnAddClicked(object obj, RoutedEventArgs args)
        {
            AddEditOutlet addEditOutlet = new AddEditOutlet((Window)this.Parent,null);
            addEditOutlet.ShowDialog();
            if(addEditOutlet.DialogResult == true)
            {
                loadTable();
            }
        }

        private void OnEditClicked(object obj, RoutedEventArgs args)
        {
            Model.Outlet.Outlet outlet = (Model.Outlet.Outlet)tblOutlet.SelectedItem;
            AddEditOutlet addEditOutlet = new AddEditOutlet((Window)this.Parent, outlet);
            addEditOutlet.ShowDialog();
            if(addEditOutlet.DialogResult == true)
            {
                loadTable();
            }
        }

        private void OnSearchClicked(object obj, RoutedEventArgs args)
        {
            string query = tbSearch.Text.Trim();

            if (!String.IsNullOrEmpty(query))
            {
                List<Model.Outlet.Outlet> filtered = new List<Model.Outlet.Outlet>();
                for (int i = 0; i < outletList.Count; i++)
                {
                    Model.Outlet.Outlet item = outletList[i];
                    if(item.nama.ToLower().Contains(query.ToLower()) || item.kab_name.ToLower().Contains(query.ToLower()) || item.prov_name.ToLower().Contains(query.ToLower()) || item.email.ToLower().Contains(query.ToLower()) || item.telp.ToLower().Contains(query.ToLower()))
                    {
                        filtered.Add(item);
                    }
                }
                tblOutlet.ItemsSource = filtered;
            }
            else
            {
                Notifier notifier = Utils.Utils.initNotification();
                notifier.ShowWarning("Silahkan ketikan kata kunci untuk mencari item");
            }
        }
    }
}
