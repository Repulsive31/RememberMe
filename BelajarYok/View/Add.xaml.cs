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
    public partial class Add : ContentPage
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)//ToDoList
        {
            Navigation.PushAsync(new BelajarYok.View.AddFolder.AddToDoList());
        }

        private void Button_Clicked_1(object sender, EventArgs e)//Tasks
        {
            Navigation.PushAsync(new BelajarYok.View.AddFolder.AddTask());
        }

        private void Button_Clicked_2(object sender, EventArgs e)//event
        {
            Navigation.PushAsync(new BelajarYok.View.AddFolder.Concentration());
        }
    }
}