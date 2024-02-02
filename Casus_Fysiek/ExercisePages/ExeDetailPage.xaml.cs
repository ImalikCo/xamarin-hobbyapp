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
    public partial class ExeDetailPage : ContentPage
    {
        public ExeDetailPage(string Exercise, string Description, string CreatedBy, string Tips)
        {
            InitializeComponent();
            lblName.Text = Exercise;
            lblTips.Text = Tips;
            lblCreatedby.Text = CreatedBy;
            lblDescription.Text = Description;

            if (lblCreatedby.Text == "Admin")
            {
                btnCollect.IsVisible = true;
            }
            else
            {
                btnRequest.IsVisible = true;
            }
        }
    }
}