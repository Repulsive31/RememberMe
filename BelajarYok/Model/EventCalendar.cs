using System;
using System.Linq;
using XCalendar.Core.Collections;
using XCalendar.Core.Models;

namespace BelajarYok.Model
{
    public class EventCalendar : Calendar<EventDay>
    {
        public ObservableRangeCollection<Event> Events { get; set; } = new ObservableRangeCollection<Event>();
        public override void UpdateDay(EventDay day, DateTime newDateTime)
        {
            base.UpdateDay(day, newDateTime);
            day.Events.ReplaceRange(Events.Where(x => x.DateTime.Date == newDateTime.Date));
        }
    }
}
