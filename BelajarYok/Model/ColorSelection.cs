using System;
using Xamarin.Forms;

namespace BelajarYok.Model
{
    public class ColorSelection : BaseObservableModel
    {
        public string ColorName { get; set; }
        public Color color { get; set; }
        public override string ToString()
        {
            return ColorName;
        }
    }
}
