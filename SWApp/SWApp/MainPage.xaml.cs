using System;
using Xamarin.Forms;

namespace SWApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            imgTruck.Source = ImageSource.FromResource("SWApp.truck.png");
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text,
                Voornaam = "Erik"
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new HomePage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
                usernameEntry.Text = string.Empty;
            }

            
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;
        }
    }
}
