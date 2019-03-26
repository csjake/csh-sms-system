namespace ScheduleModel
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public Schedule Schedule { get; set; }
        public SchedulePeriod Period { get; set; }
        public int PeriodQuantity { get; set; }
        public bool IsForAfterDate { get; set; }
        public ContactProperty RelativeToDate { get; set; }
        public MessageTemplate Message { get; set; }
    }
}