namespace MasterDatabase
{
    public class LogReferences
    {
        public int Id { get; set; }
        public Log Log { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceId { get; set; }
        public string Note { get; set; }
    }
}