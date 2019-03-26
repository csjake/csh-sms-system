using System.Collections.Generic;

namespace ScheduleModel
{
    public class MessageTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public List<Translation> Translations { get; set; }
        public List<ScheduleItem> ScheduleItems { get; set; }
    }
}