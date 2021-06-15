using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string userFirstName = firstNameEntry.Text;
            string userLastName = lastNameEntry.Text;
            string userAddress = addressEntry.Text;
            string userMobile = mobileEntry.Text;

            
            string greeting = $"Hello there {userFirstName}!!!";
            string details = $"Your Firstname is {userFirstName} and your Lastname is {userLastName}." +
                $" You live in {userAddress} and your contact number is: {userMobile}";

            detailLabel.Text = details;
            greetingLabel.Text = greeting;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string clear = string.Empty;

            firstNameEntry.Text = clear;
            lastNameEntry.Text = clear;
            addressEntry.Text = clear;
            mobileEntry.Text = clear;
            detailLabel.Text = clear;
            greetingLabel.Text = clear;
        }
    }
}
