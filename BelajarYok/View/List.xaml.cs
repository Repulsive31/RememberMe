using BelajarYok.ViewModel;
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
    public partial class List : ContentPage
    {
        private ListViewModel viewModel;
        public List()
        {
            InitializeComponent();
            viewModel = new ListViewModel();
            BindingContext = viewModel;
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