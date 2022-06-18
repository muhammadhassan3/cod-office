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
using COD_Market_Office.Model.ItemList;
using COD_Market_Office.Utils.Rest;

namespace COD_Market_Office.Page.Stock
{
    /// <summary>
    /// Interaction logic for StockIn.xaml
    /// </summary>
    public partial class StockIn : UserControl
    {
        public StockIn()
        {
            InitializeComponent();
            LoadOutlet();
        }

        private void BtnBackClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new Home());
        }

        private void OnKatRowSelected(object obj, MouseButtonEventArgs args)
        {
            MdlItem kat = (MdlItem)tblKat.SelectedItem;
            LoadMerek(kat);
        }
        private void OnMerekRowSelected(object obj, MouseButtonEventArgs args)
        {
            MdlItem kat = (MdlItem)tblKat.SelectedItem;
            MdlItem merek = (MdlItem)tblMerek.SelectedItem;
            LoadItem(kat,merek);

        }
        private void OnItemRowSelected(object obj, MouseButtonEventArgs args)
        {

        }

        private void OnOutletChanged(object obj, SelectionChangedEventArgs args)
        {
            LoadKat();
        }

        private void OnAddStockClicked(object obj, RoutedEventArgs args)
        {
            Model.Outlet.Outlet outlet = (Model.Outlet.Outlet)cbOutlet.SelectedItem;
            if (outlet != null)
            {
                AddStock addStock = new AddStock((Window)this.Parent,outlet);
                addStock.ShowDialog();
                if(addStock.DialogResult == true)
                {
                    MdlItem kat = (MdlItem)tblKat.SelectedItem, merek = (MdlItem)tblMerek.SelectedItem, item = (MdlItem)tblItem.SelectedItem ;
                    LoadKat();
                    LoadMerek(kat);
                    LoadItem(kat, merek);
                }
            }
            else MessageBox.Show("Harap pilih outlet terlebih dahulu", "Pemberitahuan");
        }

        private void EditStockClicked(object obj, RoutedEventArgs args)
        {

        }

        private void LoadOutlet()
        {
            var response = ApiRequest.GetOutlet();
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    cbOutlet.DisplayMemberPath = "nama";
                    cbOutlet.ItemsSource = response.Data.value;
                    cbOutlet.SelectedIndex = 0;
                    LoadKat();
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

        private void LoadKat()
        {
            Model.Outlet.Outlet outlet = (Model.Outlet.Outlet)cbOutlet.SelectedItem;
            if (outlet != null)
            {
                var response = ApiRequest.GetKatStock(outlet.id);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        tblKat.ItemsSource = response.Data.value;
                    }
                    else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            }
            else Utils.Utils.setErrorMessage("Harap pilih outlet terlebih dahulu");
        }

        private void LoadMerek(MdlItem kat)
        {
            Model.Outlet.Outlet outlet = (Model.Outlet.Outlet)cbOutlet.SelectedItem;
            if (kat != null && outlet != null)
            {
                var response = ApiRequest.GetMerekStock(outlet.id, kat.id);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        tblMerek.ItemsSource = response.Data.value;
                    }
                    else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

        private void LoadItem(MdlItem kat, MdlItem merek)
        {
            Model.Outlet.Outlet outlet = (Model.Outlet.Outlet)cbOutlet.SelectedItem;
            if (kat != null && merek != null && outlet != null)
            {
                var response = ApiRequest.GetItemStock(outlet.id, kat.id, merek.id);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        tblItem.ItemsSource = response.Data.value;
                    }
                    else Utils.Utils.setErrorMessage(response.ErrorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }
    }
}
