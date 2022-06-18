using COD_Market_Office.Model;
using COD_Market_Office.Page;
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

namespace COD_Market_Office
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Switcher.mainWindow = MainFrame;
            Switcher.Switch(new Login());
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked");
        }

        public void NavigatePage(UserControl page)
        {
            this.Content = page;
        }

    }
}
