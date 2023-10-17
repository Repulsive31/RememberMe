using BelajarYok.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using BelajarYok.Model;

namespace BelajarYok.ViewModel
{
    public class AddToDoListViewModel : BaseViewModel
    {
        public ICommand addToDos { get; private set; }
        public ICommand saveAll { get; set; }
  
        public ObservableCollection<ColorSelection> Colors { get; } = new ObservableCollection<ColorSelection>()
        {
            new ColorSelection(){ ColorName = "Blue", color = Color.SkyBlue},
            new ColorSelection(){ ColorName = "Green", color = Color.LightGreen},
            new ColorSelection(){ ColorName = "Red", color = Color.Red},
            new ColorSelection(){ ColorName = "Yellow", color = Color.Yellow}
        };
        public ObservableCollection<ColorSelection> Colors1 { get; } = new ObservableCollection<ColorSelection>()
        {
            new ColorSelection(){ ColorName = "Blue", color = Color.Blue},
            new ColorSelection(){ ColorName = "Green", color = Color.Green},
            new ColorSelection(){ ColorName = "Red", color = Color.Red},
            new ColorSelection(){ ColorName = "Yellow", color = Color.Yellow}
        };

        public ColorSelection SelectedBGColor { get; set; }
        public ColorSelection SelectedTextColor { get; set; }

        public AddToDoListViewModel()
        {
            toDoView = new ObservableCollection<ToDoList>();
            string text = ToDoText;
            addToDos = new Command(async () => await addToDo());
            saveAll = new Command(async () => await saveList());
        }
        async Task saveList()
        {
            //save list :V
            string y = Title;
            ToDoListHeader toDoHeader = new ToDoListHeader();
            toDoHeader.Title = y;
            toDoHeader.ToDoLists = toDoLists;
            await App.MyDatabase.CreateToDoListHeader(App.MyDatabase.db, toDoHeader);
            await Application.Current.MainPage.DisplayAlert("Success", "ToDoListHeader saved successfully!", "OK");
        }
        async Task addToDo()
        {
            string x = ToDoText;
            ToDoList ToDo = new ToDoList();
            ToDo.Text = x;
            ToDo.isDone = false;
            ToDo.backgroundColor = SelectedBGColor.color;
            ToDo.textColor = SelectedTextColor.color;
            toDoView.Add(ToDo);
            toDoLists.Add(ToDo);
        }
        public List<ToDoList> toDoLists = new List<ToDoList>();
        public ObservableCollection<ToDoList> toDoView { get; set; }
        string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }
        string toDoText;
        public string ToDoText
        {
            get
            {
                return toDoText;
            }
            set
            {
                toDoText = value;
                OnPropertyChanged();
            }
        }
    }
}
