using BelajarYok.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XCalendar.Core.Models;

namespace BelajarYok.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        private HomeViewModel viewModel;
        public Home()
        {
            InitializeComponent();
            viewModel = new HomeViewModel();
            BindingContext = viewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BelajarYok.View.Login());
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.OnAppearing();
        }
        protected async void OnDisappearing()
        {
            base.OnDisappearing();
            await viewModel.onDisapearing();
        }
    }
}