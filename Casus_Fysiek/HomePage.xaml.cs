using Casus_Fysiek.ExercisePages;
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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public HomePage(string username)
        {
            InitializeComponent();
            lblHome.Text = "Homepage of    " + username;
            lblUser.Text = username;
        }

        private void btnExercise_Clicked(object sender, EventArgs e)
        {
            string username = lblUser.Text;
            Navigation.PushAsync(new AddNewExePage(username));
        }

        private void btnShowExe_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AllExePage());
        }
    }
}