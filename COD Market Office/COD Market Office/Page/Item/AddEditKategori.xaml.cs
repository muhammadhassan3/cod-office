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
using System.Windows.Shapes;

namespace COD_Market_Office.Page.Item
{
    /// <summary>
    /// Interaction logic for AddEditKategori.xaml
    /// </summary>
    public partial class AddEditKategori : Window
    {
        private MdlItem item;
        public AddEditKategori(Window owner, MdlItem item)
        {
            InitializeComponent();
            this.item = item;
            this.Owner = owner;
            if(item == null)
            {
                this.Title = "Tambah Kategori";
            }
            else
            {
                this.Title = "Ubah Kategori";
                cbVisible.IsChecked = item.visible;
                tbName.Text = item.nama;
            }
        }

        private void btnSaveCLicked(object obj, RoutedEventArgs args)
        {
            string name = tbName.Text.Trim();
            bool visible = (bool)cbVisible.IsChecked;
            if (!String.IsNullOrEmpty(name))
            {
                var response = item == null?
                    ApiRequest.saveKategoriProduct(name, visible) : ApiRequest.editKategoriProduct(item.id, name, visible);

                if (response.IsSuccessful)
                {
                    if (response.Data.status)
                    {
                        this.DialogResult = true;
                        this.Close();
                    }
                    else Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
                else Utils.Utils.setFailedRequest(response.StatusCode);
            }
            else Utils.Utils.setErrorMessage("Nama kategori tidak boleh kosong");
            
        }
    }
}
