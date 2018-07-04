using System;
using System.Collections.Generic;
using System.Linq;

namespace UDLA.CheckIn.Data.Entities
{
    public class Schedule : Entity
    {
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }

        public virtual ICollection<ScheduleDay> ScheduleDays { get; set; }
        
        public int ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }

        public ScheduleDay GetScheduleByDay(DayOfWeek dayOfWeek)
        {
            return ScheduleDays.FirstOrDefault(s => s.DayOfWeek == dayOfWeek);
        }
    }
}
