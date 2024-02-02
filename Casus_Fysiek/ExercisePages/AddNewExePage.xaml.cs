using Casus_Fysiek.LocalDB;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casus_Fysiek.ExercisePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewExePage : ContentPage
    {
        public AddNewExePage()
        {
            InitializeComponent();
        }
        public AddNewExePage(string username)
        {
            InitializeComponent();
            lblUser.Text = username;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.ConnectionString))
            {
                conn.CreateTable<Exercises>();
            }
        }

        private void btnAddExe_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.ConnectionString))
            {
                conn.CreateTable<Exercises>();
                Exercises exercises = new Exercises()
                {
                    Exercise = entryExercise.Text,
                    CreatedByUser = lblUser.Text,
                    Description = entryDescription.Text,
                    Tips = entryTips.Text,

                };
                conn.Insert(exercises);
                Application.Current.MainPage.DisplayAlert("Success", "Hobby added to database", "OK");
                Navigation.PopAsync();
            }
        }
    }
}