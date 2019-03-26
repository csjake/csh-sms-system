using System.Collections.Generic;

namespace ScheduleModel
{
    public class SchedulePeriod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ScheduleItem> ScheduleItems { get; set; }
    }
}