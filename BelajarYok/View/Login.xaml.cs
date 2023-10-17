using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BelajarYok.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool AuthenticateUser(string username, string password)
        {
            return (username == "admin" && password == "password");
        }
        private void OnLoginClicked(object sender, EventArgs e)
        {
            string username = userEntry.Text;
            string password = passEntry.Text;

            bool checking = AuthenticateUser(username, password);

            if (checking)
            {
                Application.Current.MainPage = new NavigationPage(new Register());
            }
            else
            {
                DisplayAlert("WARNING", "Wrong Username or Password", "OK");
            }
        }
    }
}