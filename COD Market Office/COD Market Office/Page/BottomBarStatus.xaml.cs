using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
using System.Windows.Threading;

namespace COD_Market_Office.Page
{
    /// <summary>
    /// Interaction logic for BottomBarStatus.xaml
    /// </summary>
    public partial class BottomBarStatus : UserControl
    {
        bool isConnected = false;
        public BottomBarStatus()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(UpdateConnectionAndClock);
            timer.Interval = new TimeSpan(0,0,1);
            timer.Start();

            DispatcherTimer timeConnection = new DispatcherTimer();
            timeConnection.Tick += new EventHandler(isConnectionAvailable);
            timeConnection.Interval = new TimeSpan(0, 0, 10);
            timeConnection.Start();
        }

        private void UpdateConnectionAndClock(object obj, EventArgs args)
        {
            Date.Text = DateTime.Now.ToString("dddd, MMMM yyyy HH:mm:ss");
        }

        private void isConnectionAvailable(object obj, EventArgs args)
        {
            string host = "8.8.8.8";
            Ping p = new Ping();
            if (!isConnected)
            {
                Connection.Text = "Menghubungkan...";
                Connection.Foreground = new SolidColorBrush(Colors.Black);
            }
            try
            {
                PingReply result = p.Send(host, 3000);
                if (result.Status == IPStatus.Success)
                {
                    Connection.Text = "Terhubung";
                    Connection.Foreground = new SolidColorBrush(Colors.Green);
                    isConnected = true;
                }
                else
                {
                    Connection.Text = "Terputus";
                    Connection.Foreground = new SolidColorBrush(Colors.Red);
                    isConnected = false;
                }
            }
            catch (Exception ex)
            {
                Connection.Text = "Terputus";
                Connection.Foreground = new SolidColorBrush(Colors.Red);
                Console.WriteLine("Error: "+ex.Message);
                isConnected = false;
            }
        }
    }
}
