using BelajarYok.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BelajarYok.View.AddFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddToDoList : ContentPage
    {
        public AddToDoList()
        {
            InitializeComponent();
            BindingContext = new AddToDoListViewModel();
        }
    }
}