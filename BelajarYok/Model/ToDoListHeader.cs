using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace BelajarYok.Model
{
    public class ToDoListHeader : BaseObservableModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        [TextBlob("ToDoListsBlobbed")]
        public List<ToDoList> ToDoLists { get; set; }
        public string ToDoListsBlobbed { get; set; }
    }
}
