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
using COD_Market_Office.Model.Jasa;
using COD_Market_Office.Utils.Rest;
using COD_Market_Office.Utils;
using ToastNotifications;
using ToastNotifications.Messages;

namespace COD_Market_Office.Page.Jasa
{
    /// <summary>
    /// Interaction logic for ListInvoiceJasa.xaml
    /// </summary>
    public partial class ListInvoiceJasa : UserControl
    {
        public ListInvoiceJasa()
        {
            InitializeComponent();
            loadData(false);
        }

        private void OnBackClicked(object obj, EventArgs args)
        {
            Switcher.Switch(new Home());
        }

        private void loadData(bool showAll)
        {
            IRestResponse<Feedback<List<InvoiceJasa>>> response;
            if (!showAll)
            {
                response = ApiRequest.GetUnVerifiedInvoiceJasa();
            }
            else
            {
                response = ApiRequest.GetAllInvoiceJasa();
            }

            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    tblData.ItemsSource = response.Data.value;
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

        private void OnCheckChanged(object obj, EventArgs args)
        {
            loadData((bool)cbShowAll.IsChecked);

            tvJasa.Text = "";
            tvNama.Text = "";
            tvNomor.Text = "";
            tvPaket.Text = "";
            tvPrice.Text = "";
            image.Visibility = Visibility.Hidden;
        }

        private void OnRowClicked(object obj, MouseButtonEventArgs args)
        {
            InvoiceJasa invoice = (InvoiceJasa)tblData.SelectedItem;
            
            if (invoice != null)
            {
                tvJasa.Text = invoice.item.nama;
                tvNama.Text = invoice.owner.nama;
                tvNomor.Text = invoice.nomor;
                tvPaket.Text = invoice.paket.nama;
                tvPrice.Text = invoice.harga_format;
                if (invoice.foto != null)
                {
                    image.Visibility = Visibility.Visible;
                    string v = ApiRequest.BaseUrl + "/api/v1/invoice/image/" + invoice.nomor;
                    BitmapImage BitmapImage = new BitmapImage();
                    BitmapImage.BeginInit();
                    BitmapImage.UriSource = new Uri(v, UriKind.RelativeOrAbsolute);
                    BitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    BitmapImage.EndInit();
                    image.Source = BitmapImage;
                }
                else
                    image.Visibility = Visibility.Hidden;
            }
        }

        private void AproveInvoice(object obj, RoutedEventArgs args)
        {
            InvoiceJasa invoice = (InvoiceJasa)tblData.SelectedItem;
            if (invoice != null)
            {

                IRestResponse<Feedback<object>> response = ApiRequest.ApproveInvoice(invoice.id);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        Notifier notif = Utils.Utils.initNotification();
                        notif.ShowSuccess("Sukses");
                        loadData((bool)cbShowAll.IsChecked);
                    }
                    else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

        private void DenyInvoice(object obj, RoutedEventArgs args)
        {
            InvoiceJasa invoice = (InvoiceJasa)tblData.SelectedItem;
            if (invoice !=null)
            {

                IRestResponse<Feedback<object>> response = ApiRequest.DenyInvoice(invoice.nomor);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        Notifier notif = Utils.Utils.initNotification();
                        notif.ShowSuccess("Sukses");
                        loadData((bool)cbShowAll.IsChecked);
                    }
                    else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }
    }
}
