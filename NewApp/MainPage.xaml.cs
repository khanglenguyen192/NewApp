using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonEnter_OnClicked(object sender, EventArgs e)
        {
            txtName.Text = "Name: " + txtNumber.Text;
            // imgImage.Background = "green";
            // imgImage.Source = ImageSource.FromFile("Resources/drawable/book_tltd.jpg");

        }

        private void ButtonPage2_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage());
        }


    }
}
