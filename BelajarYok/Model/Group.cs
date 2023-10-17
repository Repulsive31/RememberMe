using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace BelajarYok.Model
{
    public class Group
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [TextBlob("AnggotaBlobbed")]
        public List<User> Anggota { get; set; }
        public string AnggotaBlobbed { get; set; }
    }
}
