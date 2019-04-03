namespace ScheduleModel
{
    public class MessageImplementation
    {
        public int Id { get; set; }
        public MessageGroup MessageGroup { get; set; }
        public string Template { get; set; }        
        public MessageImplementationAssociation MessageStubAssociation { get; set; }
    }
}