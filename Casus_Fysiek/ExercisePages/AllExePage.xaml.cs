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
    public partial class AllExePage : ContentPage
    {
        public AllExePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.ConnectionString))
            {
                conn.CreateTable<Exercises>();
                List<Exercises> notes = conn.Table<Exercises>().ToList();
                notesListView.ItemsSource = notes;
            }
        }
        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as Exercises;
            await Navigation.PushAsync(new ExeDetailPage(mydetails.Exercise, mydetails.Description, mydetails.CreatedByUser, mydetails.Tips));

        }
    }
}