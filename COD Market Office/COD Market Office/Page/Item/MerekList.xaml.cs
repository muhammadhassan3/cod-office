using COD_Market_Office.Model.ItemList;
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

namespace COD_Market_Office.Page.Item
{
    /// <summary>
    /// Interaction logic for MerekList.xaml
    /// </summary>
    public partial class MerekList : UserControl
    {
        private MdlItem kategori;
        private List<MdlItem> merekRegistered;
        public MerekList(MdlItem kategori)
        {
            InitializeComponent();
            this.kategori = kategori;
            lblKategori.Content = $"Merek Terdaftar di Kategori {kategori.nama}";
            getRegisteredMerek(kategori.id);
            getAllMerek();
        }

        private void btnBackClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new ItemList());
        }

        private void btnRegisterClicked(object obj, RoutedEventArgs args)
        {
            MdlItem merek = (MdlItem)tblAllMerek.SelectedItem;
            if (merek != null) {
                var response = ApiRequest.addMerekProduct(kategori.id,merek.id);
                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        merekRegistered.Add(merek);
                        tblMerek.ItemsSource = merekRegistered;
                    }
                    else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            } else Utils.Utils.setErrorMessage("Harap Pilih Merek Terlebih Dahulu");
        }

        private void getRegisteredMerek(long katId)
        {
            var response = ApiRequest.getMerekProductList(katId);
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    merekRegistered = response.Data.value;
                    tblMerek.ItemsSource = merekRegistered;
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else Utils.Utils.setFailedRequest(response.StatusCode);
        }

        private void getAllMerek()
        {
            var response = ApiRequest.getAllMerekList();
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    tblAllMerek.ItemsSource = response.Data.value;
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else Utils.Utils.setFailedRequest(response.StatusCode);
        }

        private void btnAddClicked(object obj, RoutedEventArgs args)
        {
            AddEditMerek add = new AddEditMerek((Window)this.Parent, null);
            if(add.ShowDialog() == true)
            {
                getAllMerek();
            }

        }

        private void btnEditClicked(object obj, RoutedEventArgs args)
        {
            MdlItem merek = (MdlItem)tblAllMerek.SelectedItem;
            AddEditMerek edit = new AddEditMerek((Window)this.Parent, merek);
            if(edit.ShowDialog() == true)
            {
                getAllMerek();
            }
        }
    }
}
