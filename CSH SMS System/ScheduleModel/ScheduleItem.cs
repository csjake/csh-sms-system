namespace ScheduleModel
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public Schedule Schedule { get; set; }
        public string Period { get; set; }
        public int PeriodQuantity { get; set; }
        public bool IsForAfterDate { get; set; }
        public string RelativeToDate { get; set; }
        public MessageTemplate Message { get; set; }
    }
}