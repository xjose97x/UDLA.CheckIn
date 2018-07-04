using System;
using System.Collections.Generic;

namespace UDLA.CheckIn.Data.Entities
{
    public class ScheduleDay : Entity
    {
        public DayOfWeek DayOfWeek { get; set; }
        public virtual ICollection<ScheduleHour> ScheduleHours { get; set; }

        public int ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
