using System;
using Xamarin.Forms;
using SQLite;

namespace BelajarYok.Model
{
    public class ToDoList : BaseObservableModel
    {
        public int headerId;
        public string Text { get; set; }
        public bool isDone { get; set; }
        public Color textColor { get; set; }
        public Color backgroundColor { get; set; }

    }
}
