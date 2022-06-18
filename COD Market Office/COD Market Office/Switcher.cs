using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace COD_Market_Office
{
    class Switcher
    {
        public static Frame mainWindow;

        public static void Switch(UserControl page)
        {
            mainWindow.Navigate(page);
        }

    }
}
