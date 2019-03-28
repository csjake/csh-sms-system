using System.Collections.Generic;

namespace ScheduleModel
{
    public class ScheduleItem : IRelativeSchedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Schedule Schedule { get; set; }  
        public List<ScheduleItemReminder> ScheduleItemReminders { get; set; }
        public SchedulePeriod Period { get; set; }
        public int PeriodQuantity { get; set; }
        public BeforeAfter BeforeAfter { get; set; }
    }
}