using System;
using System.Collections.Generic;

namespace MasterDatabase
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string MotherName { get; set; }
        public string ChildName { get; set; }
        public DateTime ChildDOB { get; set; }
        public DateTime MmrBaseDate { get; set; }
        public DateTime PentaBaseDate { get; set; }
        public DateTime PrenatalBaseDate { get; set; }
        public string SourceGroupNames { get; set; }
        public List<GroupContact> Groups { get; set; }
        public DateTime SourceDate { get; set; }
        public string SourceType { get; set; }
        public string SourceKey { get; set; }
                     
    }
}
