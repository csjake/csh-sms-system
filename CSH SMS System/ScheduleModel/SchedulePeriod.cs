using System.Collections.Generic;

namespace ScheduleModel
{
    public class SchedulePeriod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ScheduleItemReminder> ScheduleItems { get; set; }
    }
}