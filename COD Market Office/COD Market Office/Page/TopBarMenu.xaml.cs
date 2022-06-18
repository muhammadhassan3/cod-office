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
using COD_Market_Office.Page.Jasa;
using COD_Market_Office.Utils.Rest;
using COD_Market_Office.Model;
using COD_Market_Office.Page.Outlet;
using COD_Market_Office.Model.Outlet;
using COD_Market_Office.Page.User;
using COD_Market_Office.Page.Stock;
using COD_Market_Office.Page.Item;

namespace COD_Market_Office.Page
{
    /// <summary>
    /// Interaction logic for TopBarMenu.xaml
    /// </summary>
    public partial class TopBarMenu : UserControl
    {
        public TopBarMenu()
        {
            InitializeComponent();
            initGrant();
        }

        private void initGrant()
        {
            bool JasaMenu = false, OutletMenu = false;
            if (Utils.Utils.checkGrant(new Grant.Type[] { Grant.Type.ADMINISTRATOR, Grant.Type.JASA_INPUTER }))
            {
                listJasa.Visibility = Visibility.Visible;
                JasaMenu = true;
            }
            else listJasa.Visibility = Visibility.Collapsed;

            if (Utils.Utils.checkGrant(new Grant.Type[] { Grant.Type.ADMINISTRATOR, Grant.Type.INVOICE_VALIDATOR }))
            {
                invJasa.Visibility = Visibility.Visible;
                JasaMenu = true;
            }
            else invJasa.Visibility = Visibility.Collapsed;
            if (JasaMenu)
            {
                menuJasa.Visibility = Visibility.Visible;
            }
            else menuJasa.Visibility = Visibility.Collapsed;

            if (Utils.Utils.checkGrant(new Grant.Type[] { Grant.Type.ADMINISTRATOR, Grant.Type.KEPALA_TOKO })) {
                listOutlet.Visibility = Visibility.Visible;
                OutletMenu = true;
            } else listOutlet.Visibility = Visibility.Collapsed;

            if (Utils.Utils.checkGrant(new Grant.Type[] { Grant.Type.ADMINISTRATOR, Grant.Type.INVOICE_VALIDATOR }))
            {
                invOutlet.Visibility = Visibility.Visible;
                OutletMenu = true;
            }
            else invOutlet.Visibility = Visibility.Collapsed;

            if (OutletMenu)
            {
                menuOutlet.Visibility = Visibility.Visible;
            }
            else menuOutlet.Visibility = Visibility.Collapsed;

        }

        private void listJasa_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ListJasa());
        }

        private void ListInvoiceClick(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new ListInvoiceJasa());
        }

        private void ListOutletClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new ListOutlet());
        }

        private void ListInvoiceOutletClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new ListInvoiceOutlet());
        }

        private void ListOrderClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new OrderProcessing());
        }

        private void ListUserClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new UserList());
        }

        private void ListKaryawanClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new ListUserKaryawan());
        }

        private void StockItemClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new StockIn());
        }

        private void ListItemClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new ItemList());
        }
    }
}
