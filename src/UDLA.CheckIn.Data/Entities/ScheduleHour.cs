using System;

namespace UDLA.CheckIn.Data.Entities
{
    public class ScheduleHour : Entity
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int ScheduleDayId { get; set; }
        public virtual ScheduleDay ScheduleDay { get; set; }
    }
}
