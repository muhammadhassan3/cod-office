using COD_Market_Office.Model.Order;
using COD_Market_Office.Page;
using COD_Market_Office.Page.Order;
using COD_Market_Office.Utils;
using COD_Market_Office.Utils.Rest;
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
using ToastNotifications;
using ToastNotifications.Lifetime.Clear;

namespace COD_Market_Office.Model.Outlet
{
    /// <summary>
    /// Interaction logic for OrderProcessing.xaml
    /// </summary>
    public partial class OrderProcessing : UserControl
    {
        private bool isItemSelected = false;
        private int status = 0;
        public OrderProcessing()
        {
            InitializeComponent();
            loadOutlet();
        }

        private void loadOutlet()
        {
            var response = ApiRequest.GetOutlet();
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    cbOutlet.SelectedValuePath = "id";
                    cbOutlet.DisplayMemberPath = "nama";
                    cbOutlet.ItemsSource = response.Data.value;
                    cbOutlet.SelectedIndex = 0;
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

        private void OnBackPressed(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new Home());
        }

        private void OnOutletSelected(object obj, SelectionChangedEventArgs args)
        {
            Outlet outlet = (Outlet)cbOutlet.SelectedItem;
            int status = tabControl.SelectedIndex + 1;
            if(status != 0)loadData(outlet.id,status);
        }

        private void OnStatusSelected(object obj, SelectionChangedEventArgs args)
        {
            Outlet outlet = (Outlet)cbOutlet.SelectedItem;
            int status = tabControl.SelectedIndex + 1;
            if (status != this.status && status != 0)
            {
                loadData(outlet.id,status);
                this.status = status;
            }
        }


        private void OnRowClicked(object obj, MouseButtonEventArgs args)
        {
            Console.WriteLine("Row Selected");
            var tab = tabControl.SelectedIndex;
            DataGrid table = null;
            isItemSelected = true;
            switch (tab)
            {
                case 0:
                    table = tblWaiting;
                    break;
                case 1:
                    table = tblOnProcess;
                    break;
                case 2:
                    table = tblWaitingCourrier;
                    break;
                case 3:
                    table = tblOnDelivery;
                    break;
                case 4:
                    table = tblArrive;
                    break;
            }
            if(table != null)
            {
                MdlOrderkat order = (MdlOrderkat)table.SelectedItem;
                Outlet outlet = (Outlet)cbOutlet.SelectedItem;
                if(order != null)
                {
                    var response = ApiRequest.GetOrderItem(outlet.id, order.id);
                    if (response.IsSuccessful)
                    {
                        if (response.Data.status)
                        {
                            tblDetail.ItemsSource = response.Data.value.item;
                        }
                        else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                    }
                    else
                    {
                        Utils.Utils.setFailedRequest(response.StatusCode);
                    }
                }
            }
        }

        private void loadData(long outletId,int status)
        {
            TraceUtils.LogMethodCall(outletId, status);
            //if (Outlet.id != null) { 
                var response = ApiRequest.GetOrder(status,outletId);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        switch (status)
                        {
                            case 1:
                                tblWaiting.ItemsSource = response.Data.value;
                                break;
                            case 2:
                                tblOnProcess.ItemsSource = response.Data.value;
                                break;
                            case 3:
                                tblWaitingCourrier.ItemsSource = response.Data.value;
                                break;
                            case 4:
                                tblOnDelivery.ItemsSource = response.Data.value;
                                break;
                            case 5:
                                tblArrive.ItemsSource = response.Data.value;
                                break;
                        }
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
            /*}
            else
            {
                Dispatcher.BeginInvoke(new Action(() => MessageBox.Show("Harap Pilih Outlet Terlebih Dahulu", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Error)));
            }*/

        }

        private void OnProcessClicked(object obj, RoutedEventArgs args)
        {
            if (isItemSelected)
            {
                int status = tabControl.SelectedIndex + 1;
                MdlOrderkat orderKat = null;
                switch (status)
                {
                    case 1:
                        orderKat = (MdlOrderkat)tblWaiting.SelectedItem;
                        break;
                    case 2:
                        orderKat = (MdlOrderkat)tblOnProcess.SelectedItem;
                        break;
                    case 3:
                        orderKat = (MdlOrderkat)tblWaitingCourrier.SelectedItem;
                        break;
                    case 4:
                        orderKat = (MdlOrderkat)tblOnDelivery.SelectedItem;
                        break;
                    case 5:
                        orderKat = (MdlOrderkat)tblArrive.SelectedItem;
                        break;
                }
                if (orderKat == null)
                {
                    Dispatcher.BeginInvoke(new Action(() => MessageBox.Show("Harap pilih item terebih dahulu", "Pemberitahuan", MessageBoxButton.OK, MessageBoxImage.Error)));
                    return;
                }
                if(status != 3 && status != 5)
                {
                    var response = ApiRequest.UpdateOrder(orderKat.id, status);
                    if (response.IsSuccessful)
                    {
                        if (response.Data.status)
                        {
                            Outlet outlet = (Outlet)cbOutlet.SelectedItem;
                            loadData(outlet.id,status);
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
                }else if(status == 5)
                {
                    var response = ApiRequest.setFinish(orderKat.id);
                    if (response.IsSuccessful)
                    {
                        if (response.Data.status)
                        {
                            Outlet outlet = (Outlet)cbOutlet.SelectedItem;
                            loadData(outlet.id, status);
                        }
                        else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                    }
                    else Utils.Utils.setFailedRequest(response.StatusCode);
                }
                else
                {
                    Outlet outlet = (Outlet)cbOutlet.SelectedItem;
                    CourierTask task = new CourierTask((Window)this.Parent,outlet.id);
                    task.ShowDialog();
                    if(task.DialogResult == true)
                    {
                        loadData(outlet.id,status);
                    }
                }
            }
            else
            {
                Dispatcher.BeginInvoke(new Action(() => MessageBox.Show("Harap Pilih Order Terlebih Dahulu", "Pemberitahuan", MessageBoxButton.OK, MessageBoxImage.Error)));
            }
        }

    }
}
