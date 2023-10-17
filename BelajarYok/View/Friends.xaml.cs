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
    public partial class Friends : ContentPage
    {
        public Friends()
        {
            InitializeComponent();
        }

        private bool isAddImageButtonClicked = false;
        private void OnSearchEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue;
            if (searchText == "admin" && isAddImageButtonClicked)
            {
                // Show the image, text label, and button
                contentFrame.IsVisible = true;
            }
            else
            {
                // Hide the image, text label, and button
                contentFrame.IsVisible = false;
            }
        }
        private void OnAddButtonClicked(object sender, System.EventArgs e)
        {
            // Change the button color when clicked
            addButton.BackgroundColor = Color.Transparent;
            addButton.TextColor = Color.FromHex("#bcfe2f");
            addButton.Text = "Added";
            friendText.Text = "Sudah di daftarkan sebagai teman";
        }
        private void OnAddImageButtonClicked(object sender, EventArgs e)
        {
            isAddImageButtonClicked = true;
            contentFrame.IsVisible = true;
        }
    }
}
    
