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

namespace COD_Market_Office.Page.User
{
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList : UserControl
    {
        public UserList()
        {
            InitializeComponent();
            LoadItem();
        }

        private void BtnBackClicked(object obj, RoutedEventArgs args)
        {
            Switcher.Switch(new Home());
        }

        private void LoadItem()
        {
            var response = ApiRequest.getUserList(null);
            if (response.IsSuccessful)
            {
                if (response.Data.status)
                {
                    tblUser.ItemsSource = response.Data.value;
                }
                else
                {
                    Utils.Utils.setErrorMessage(response.Data.errorMessage);
                }
            }
            else
            {
                Utils.Utils.setFailedRequest(response.StatusCode);
            }
        }

        private void EditClicked(object obj, RoutedEventArgs args)
        {
            Model.User user = (Model.User)tblUser.SelectedItem;
            AddEditUser addEdit = new AddEditUser((Window)this.Parent, user);
            addEdit.ShowDialog();
            if(addEdit.DialogResult == true)
            {
                LoadItem();
            }
        }

        private void BtnSearchClicked(object obj, RoutedEventArgs args)
        {
            string query = tbSearch.Text.Trim();
            List<Model.User> userList = (List<Model.User>)tblUser.ItemsSource;
            List<Model.User> filterResult = new List<Model.User>();
            foreach (Model.User user in userList)
            {
                if(user.nama.ToLower().Equals(query.ToLower()) || user.telp.ToLower().Equals(query.ToLower()))
                {
                    filterResult.Add(user);
                }
            }
            tblUser.ItemsSource = filterResult;
        }
    }
}
