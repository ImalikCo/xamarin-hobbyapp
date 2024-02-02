using Casus_Fysiek.LocalDB;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casus_Fysiek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void BtnCreate_Clicked(object sender, EventArgs e)
        {
            Users users = new Users()
            {
                Username = EntryUsername.Text,
                Password = EntryPassword.Text,

            };
            using (SQLiteConnection conn = new SQLiteConnection(App.ConnectionString))
            {
                conn.CreateTable<Users>();
                var myuserquery = conn.Table<Users>().Where(u => u.Username.Equals(EntryUsername.Text)).FirstOrDefault();
                if (myuserquery != null)
                {
                    Application.Current.MainPage.DisplayAlert("Error", "Username bestaat al ", "OK");
                }
                else
                {
                    int rowsAdded = conn.Insert(users);
                    Application.Current.MainPage.DisplayAlert("Success", "User geregistreerd ", "OK");
                }


            }
        }
    }
}