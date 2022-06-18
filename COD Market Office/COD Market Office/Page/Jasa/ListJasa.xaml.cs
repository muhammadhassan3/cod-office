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

using COD_Market_Office.Utils.Rest;
using COD_Market_Office.Model;
using COD_Market_Office.Model.Jasa;
using COD_Market_Office.Page.Jasa;
using ToastNotifications;
using ToastNotifications.Messages;

namespace COD_Market_Office.Page
{
    /// <summary>
    /// Interaction logic for ListJasa.xaml
    /// </summary>
    public partial class ListJasa : UserControl
    {
        private List<Kategori> kategoriList;
        private List<ItemJasa> itemJasaList;
        public ListJasa()
        {
            InitializeComponent();
            loadKatData();
        }
        private void onBackClick(object obj, EventArgs args)
        {
            Switcher.Switch(new Home());
        }

        private void OnBtnAddClick(object obj, EventArgs args)
        {
            AddKatJasa addKatJasa = new AddKatJasa((Window)this.Parent);
            addKatJasa.ShowDialog();
            if(addKatJasa.DialogResult == true)
            {
                Notifier notif = Utils.Utils.initNotification();
                notif.ShowSuccess("Sukses");
                loadKatData();
            }
        }

        private void OnBtnEditClick(object obj, EventArgs args)
        {
            Kategori kategori = (Kategori)dataKat.SelectedItems[0];
            if (kategori != null)
            {
                EditKatJasa editKatJasa = new EditKatJasa((Window)this.Parent, kategori);
                editKatJasa.ShowDialog();
                if(editKatJasa.DialogResult == true)
                {
                    Notifier notif = Utils.Utils.initNotification();
                    notif.ShowSuccess("Sukses");
                    loadKatData();
                }
            }
            else
            {
                MessageBox.Show("Harap Pilih Kategori Terlebih dahulu");
            }
        }

        private void loadKatData()
        {
            IRestResponse<Feedback<List<Kategori>>> response = ApiRequest.GetKategoriJasa();
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    kategoriList = response.Data.value;
                    dataKat.ItemsSource = kategoriList;
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else
            {
                Console.WriteLine(response.ErrorException);
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }


        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Kategori item = (Kategori)dataKat.SelectedItems[0];
            
            IRestResponse<Feedback<List<ItemJasa>>> response = ApiRequest.getItemJasa(item.id);
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    itemJasaList = response.Data.value;
                    dataItem.ItemsSource = itemJasaList;
                    Console.WriteLine($"Get {itemJasaList.Count} Items");
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else Utils.Utils.setFailedRequest(response.StatusCode);

        }
    }
}
