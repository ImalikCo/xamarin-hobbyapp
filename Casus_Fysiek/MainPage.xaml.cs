using Casus_Fysiek.LocalDB;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Casus_Fysiek
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            bool isNameEmpty = string.IsNullOrEmpty(EntryUsername.Text);
            bool isPassEmpty = string.IsNullOrEmpty(EntryPassword.Text);
            if (isNameEmpty || isPassEmpty)
            {
                Application.Current.MainPage.DisplayAlert("Error", "Beide velden moeten worden ingevuld", "OK");
            }
            else
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.ConnectionString))
                {
                    var myuserquery = conn.Table<Users>().Where(u => u.Username.Equals(EntryUsername.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();
                    if (myuserquery != null)
                    {
                        string username = EntryUsername.Text;
                        HomePage homePage = new HomePage(username);
                        Navigation.PushAsync(new HomePage(username));
                    }
                    else
                    {
                        Application.Current.MainPage.DisplayAlert("Error", "Username of wachtwoord is niet gevonden ", "OK");
                    }
                }

            }
        }

        private void BtnRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        private void BtnForgot_Clicked(object sender, EventArgs e)
        {

        }
    }
}
