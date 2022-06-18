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
using COD_Market_Office.Utils.Rest;
using COD_Market_Office.Model;

namespace COD_Market_Office.Page
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            lblName.Text = ApiRequest.user.owner.nama;
            string grant = Grant.GetName(ApiRequest.user.jabatan);
            lblGrant.Text = grant;

        }

        private void Logout(object obj, EventArgs args)
        {
            MessageBoxResult result = MessageBox.Show("Apakah anda yakin ingin keluar?", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                var window = Window.GetWindow(this);
                window.Close();
            }
        }
    }
}
