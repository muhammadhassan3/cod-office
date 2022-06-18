using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;
using ToastNotifications.Messages;
using COD_Market_Office.Model;
using COD_Market_Office.Utils.Rest;
using ToastNotifications.Lifetime.Clear;
using System.Text.RegularExpressions;
using System.Globalization;

namespace COD_Market_Office.Utils
{
    class Utils
    {

        public static byte[] Encrypt(string text)
        {
            byte[] encrypted;
            string keyString = "?+$GqujSHWwh8m=FnZJF5R9xqVb6uXML";
            using (AesManaged aes = new AesManaged())
            {
                byte[] key = Encoding.UTF8.GetBytes(keyString);
                ICryptoTransform encryptor = aes.CreateEncryptor(key, aes.IV);
                using(MemoryStream ms = new MemoryStream())
                {
                    using(CryptoStream cs = new CryptoStream(ms,encryptor,CryptoStreamMode.Write))
                    {
                        using (StreamWriter stream = new StreamWriter(cs))
                            stream.Write(text);
                        encrypted = ms.ToArray();
                        Console.WriteLine(String.Join(" ", key) + " "+Encoding.UTF8.GetString(key));
                    }
                }
            }
            Console.WriteLine(String.Join(" ",encrypted));
            return encrypted;
        }

        public static void setFailedRequest(HttpStatusCode code)
        {
            Notifier notif = initNotification();
            notif.ShowError($"Gagal Memproses Permintaan\nHarap Periksa Koneksi Internet Anda ({code})");
        }

        public static void setErrorMessage(string message)
        {
            Notifier notif = initNotification();
            notif.ShowWarning("message");
        }

        public static long getFileSize(string filePath)
        {
            //if you don't have permission to the folder, Directory.Exists will return False
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                //if you land here, it means you don't have permission to the folder
                Console.WriteLine("Permission denied");
                return -1;
            }
            else if (File.Exists(filePath))
            {
                return new FileInfo(filePath).Length;
            }
            return 0;
        }

        public static Notifier initNotification()
        {
            Notifier notifier = new Notifier(cfg =>
            {
                cfg.PositionProvider = new WindowPositionProvider(
                    parentWindow: Application.Current.MainWindow,
                    corner: Corner.BottomRight,
                    offsetX: 10,
                    offsetY: 10);
                cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                    notificationLifetime: TimeSpan.FromSeconds(5),
                    maximumNotificationCount: MaximumNotificationCount.FromCount(3));
                cfg.Dispatcher = Application.Current.Dispatcher;

                cfg.DisplayOptions.TopMost = true;

            });
            notifier.ClearMessages(new ClearAll());
            return notifier;
        }

        public static bool checkGrant(Grant.Type[] grants)
        {
            foreach(Grant.Type grant in grants)
            {
                if (ApiRequest.user.jabatan == grant)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool isNumericInput(string text)
        {
            Regex regex = new Regex("[^0-9.-]+"); //Disallowed Character
            return !regex.IsMatch(text); //Reverse result
        }

        public static string convertToRupiah(string text)
        {
            long value = long.Parse(text);
            return value.ToString("C0", CultureInfo.CreateSpecificCulture("id-ID"));
        }


    }
}
