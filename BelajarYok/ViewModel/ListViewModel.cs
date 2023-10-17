using BelajarYok.Model;
using BelajarYok.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace BelajarYok.ViewModel
{
    public class ListViewModel:BaseViewModel
    {
        public Command LoadToDoListCommand { get; }
        public ObservableCollection<ToDoListHeader> toDoView { get; set; }
        public ListViewModel()
        {
            toDoView = new ObservableCollection<ToDoListHeader>(); 
        }
        public async Task OnAppearing()
        {
            // Load data from the database
            List<ToDoListHeader> data = await App.MyDatabase.GetToDoListHeader();

            // Clear the existing collection
            toDoView.Clear();

            // Add the loaded data to the collection
            foreach (var item in data)
            {
                toDoView.Add(item);
            }
        }
        public async Task onDisapearing()
        {
            toDoView.Clear();
        }


  
    }
}
