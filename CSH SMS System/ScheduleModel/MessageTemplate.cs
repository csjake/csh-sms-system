using System.Collections.Generic;

namespace ScheduleModel
{
    public class MessageTemplate
    {
        public int Id { get; set; }
        public string Template { get; set; }
        public List<ScheduleItem> ScheduleItems { get; set; }
    }
}