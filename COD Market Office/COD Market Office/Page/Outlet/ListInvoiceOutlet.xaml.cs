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
using COD_Market_Office.Model.Outlet;
using COD_Market_Office.Utils.Rest;

namespace COD_Market_Office.Page.Outlet
{
    /// <summary>
    /// Interaction logic for ListInvoiceOutlet.xaml
    /// </summary>
    public partial class ListInvoiceOutlet : UserControl
    {
        public ListInvoiceOutlet()
        {
            InitializeComponent();
        }

        private void OnBackClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new Home());
        }

        private void initData()
        {
            var response = ApiRequest.getInvoiceOutlet();
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    tblInvoice.ItemsSource = response.Data.value;
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

        private void OnRowClicked(object obj, MouseButtonEventArgs args)
        {
            OutletInvoice invoice = (OutletInvoice)tblInvoice.SelectedItem;
            if(invoice != null)
            {
                tvName.Text = invoice.name;
                tvOutlet.Text = invoice.outlet_name;
                tvPrice.Text = invoice.value_format;
                tvInfo.Text = invoice.ket;
                tvDate.Text = invoice.expiredAt;

            }
        }

    }
}
