using System;
using Xamarin.Forms;

namespace BelajarYok.Model
{
    public class Event : BaseObservableModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public Color Color { get; set; }
    }
}
