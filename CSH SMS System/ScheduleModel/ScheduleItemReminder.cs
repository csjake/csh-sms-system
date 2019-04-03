namespace ScheduleModel
{
    public class ScheduleItemReminder : IRelativeSchedule
    {
        public int Id { get; set; }
        public ScheduleItem ScheduleItem { get; set; }
        public SchedulePeriod Period { get; set; }
        public int PeriodQuantity { get; set; }
        public BeforeAfter BeforeAfter { get; set; }        
        public MessageStub Message { get; set; }
    }
}