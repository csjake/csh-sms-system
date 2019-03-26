using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleModel
{
    public class Contact
    {
        public int Id { get; set; }
        public string SourceType { get; set; }
        public string SourceId { get; set; }
        public DateTime SourceDate { get; set; }
        public long SourceDateUnix { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string MotherName { get; set; }
        public string ChildName { get; set; }
        public bool IsMother { get; set; }
        public DateTime MmrDate { get; set; }
        public DateTime PentaDate { get; set; }
        public DateTime PrenatalDate { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
