namespace ScheduleModel
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public Schedule Schedule { get; set; }
        public MessageTemplate Message { get; set; }
    }
}