using COD_Market_Office.Model;
using COD_Market_Office.Model.Order;
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
using System.Windows.Shapes;

namespace COD_Market_Office.Page.Order
{
    /// <summary>
    /// Interaction logic for CourierTask.xaml
    /// </summary>
    public partial class CourierTask : Window
    {
        private long outletId { get; set; }
        public CourierTask(Window parent, long outletId)
        {
            InitializeComponent();
            this.Owner = parent;
            this.ShowInTaskbar = false;
            this.Topmost = true;
            this.outletId = outletId;
            loadCourier();
            loadTask();
        }

        private void OnSaveClicked(object obj, RoutedEventArgs args)
        {
            Model.User courier = (Model.User)cbCourier.SelectedItem;
            List<long> orderId = new List<long>();
            foreach(MdlOrderkat item in tblTask.ItemsSource)
            {
                if (item.isSelected)
                {
                    orderId.Add(item.id);
                }
            }

            if(orderId.Count > 0)
            {
                var response = ApiRequest.SetCourier(courier.id, orderId);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        this.Close();
                        this.DialogResult = true;
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
            else
            {
                Dispatcher.BeginInvoke(new Action(() => MessageBox.Show("Harap pilih item terlebih dahulu", "Pemberitahuan", MessageBoxButton.OK, MessageBoxImage.Warning)));
            }
        }

        private void loadCourier()
        {
            var response = ApiRequest.getKurir(outletId);
            if (response.IsSuccessful)
            {
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        cbCourier.DisplayMemberPath = "nama";
                        cbCourier.ItemsSource = response.Data.value;
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
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

        private void OnItemSelected(object obj, MouseButtonEventArgs args)
        {
            Console.WriteLine("Selecting item");
            List<MdlOrderkat> list = (List<MdlOrderkat>)tblTask.ItemsSource;
            int position = tblTask.SelectedIndex;
            list[position].isSelected = !list[position].isSelected;
            tblTask.ItemsSource = list;

        }

        private void loadTask()
        {
            var response = ApiRequest.GetOrder(3, outletId);
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    tblTask.ItemsSource = response.Data.value;
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
