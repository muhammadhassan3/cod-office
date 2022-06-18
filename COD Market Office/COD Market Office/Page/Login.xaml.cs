using COD_Market_Office.Model;
using COD_Market_Office.Utils.Rest;
using COD_Market_Office.Utils;
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
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;
using ToastNotifications.Messages;

namespace COD_Market_Office.Page
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            username.Text = "08156649383";
            password.Password = "12Hassan34@Gmail.com/adminCod";
        }

        private void OnButtonClick(object obj, EventArgs e)
        {
            string telp = username.Text,
                pass = password.Password;
            Notifier notifier = Utils.Utils.initNotification();
            if (!String.IsNullOrWhiteSpace(telp) && !String.IsNullOrWhiteSpace(pass))
            {
                IRestResponse<Feedback<string>> encrypted = ApiRequest.Encrypt(pass);
                if (encrypted.IsSuccessful)
                {
                    if (encrypted.Data.status)
                    {
                        IRestResponse<Feedback<UserKaryawan>> result = ApiRequest.Login(telp, encrypted.Data.value);
                        if (result.IsSuccessful)
                        {
                            ApiRequest.user = result.Data.value;
                            ApiRequest.username = telp;
                            ApiRequest.password = pass;
                            Switcher.Switch(new Home());
                            notifier.ShowSuccess("Login Sukses");
                        }
                        else
                        {
                            Utils.Utils.setFailedRequest(result.StatusCode);
                        }
                    }
                }
                else
                {
                    Utils.Utils.setFailedRequest(encrypted.StatusCode);
                }
            }
            else if (String.IsNullOrWhiteSpace(telp))
            {
                notifier.ShowWarning("Nomor Telepon Harus Terisi");
            }
            else if (String.IsNullOrWhiteSpace(pass))
            {
                notifier.ShowWarning("Password Harus Terisi");
            }
        }

    }
}
