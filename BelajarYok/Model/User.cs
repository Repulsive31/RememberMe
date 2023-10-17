using System;
using Xamarin.Forms;
using SQLite;
using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;

namespace BelajarYok.Model
{
    public class User : BaseObservableModel
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [TextBlob("EventsBlobbed")]
        public List<Event> events { get; set; }
        public string EventBlobbed { get; set; }
        [TextBlob("ToDoListsBlobbed")]
        public List<ToDoListHeader> todoLists { get; set; }
        public string ToDoListsBlobbed { get; set; }

    }
}
