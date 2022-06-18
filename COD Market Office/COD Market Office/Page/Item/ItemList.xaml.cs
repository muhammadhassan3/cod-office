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
    /// Interaction logic for ItemList.xaml
    /// </summary>
    public partial class ItemList : UserControl
    {
        public ItemList()
        {
            InitializeComponent();
            loadKategori();
        }

        private void btnBackClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new Home());
            loadKategori();
        }

        private void tblKatClicked(object obj, MouseButtonEventArgs args)
        {
            MdlItem item = (MdlItem)tblKat.SelectedItem;
            if(item != null)
            {
                loadMerek(item.id);
            }
        }

        private void tblMerekClicked(object obj, MouseButtonEventArgs args)
        {
            MdlItem merek = (MdlItem)tblMerek.SelectedItem,
                kat = (MdlItem)tblKat.SelectedItem;
            if(merek != null && kat != null)
            {
                loadItem(kat.id, merek.id);
            }
        }

        private void loadKategori()
        {
            var response = ApiRequest.getKategoriProductList();
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    tblKat.ItemsSource = response.Data.value;
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

        private void loadMerek(long katId)
        {
            var response = ApiRequest.getMerekProductList(katId);
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

        private void loadItem(long katId, long merekId)
        {
            var response = ApiRequest.getItemProductList(katId, merekId);
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    tblItem.ItemsSource = response.Data.value;
                }
                else Utils.Utils.setErrorMessage(response.Data.errorMessage);
            }
            else Utils.Utils.setFailedRequest(response.StatusCode);
        }

        private void btnAddKatClicked(object obj, RoutedEventArgs args)
        {
            AddEditKategori add = new AddEditKategori((Window)this.Parent, null);
            if(add.ShowDialog() == true)
            {
                loadKategori();
            }
        }

        private void btnEditKatClicked(object obj, RoutedEventArgs args)
        {
            MdlItem kategori = (MdlItem)tblKat.SelectedItem;
            if (kategori != null)
            {
                AddEditKategori edit = new AddEditKategori((Window)this.Parent, kategori);
                if (edit.ShowDialog() == true)
                {
                    loadKategori();
                }
            }
        }

        private void btnShowMerekList(object obj, RoutedEventArgs args)
        {
            MdlItem kategori = (MdlItem)tblKat.SelectedItem;
            if (kategori != null)
            {
                MerekList merek = new MerekList(kategori);
                Switcher.Switch(merek);
            }
        }

        private void btnAddItemClicked(object obj, RoutedEventArgs args)
        {
            MdlItem kat = (MdlItem)tblKat.SelectedItem,
                merek = (MdlItem)tblMerek.SelectedItem;
            if(merek != null && kat != null)
            {
                AddEditItem add = new AddEditItem((Window)this.Parent, kat, merek, null);
                if (add.ShowDialog() == true)
                {
                    loadItem(kat.id, merek.id);
                }
            }
        }

        private void btnEditItemClicked(object obj, RoutedEventArgs args)
        {
            MdlItem kategori = (MdlItem)tblKat.SelectedItem,
                merek = (MdlItem)tblMerek.SelectedItem,
                item = (MdlItem)tblItem.SelectedItem;
            if(kategori !=null && merek != null && item != null)
            {
                AddEditItem edit = new AddEditItem((Window)this.Parent, kategori, merek, item);
                if(edit.ShowDialog() == true)
                {
                    loadItem(kategori.id, merek.id);
                }
            }
        }
    }
}
