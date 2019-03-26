namespace ScheduleModel
{
    public class Translation
    {
        public int Id { get; set; }
        public Language Language { get;set;}
        public string MessageTemplate { get; set; }
        public MessageTemplate Parent { get; set; }
    }
}