using System;
using System.Collections.Generic;

namespace MasterDatabase
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MotherName { get; set; }
        public string ChildName { get; set; }
        public DateTime MmrBaseDate { get; set; }
        public DateTime PentaBaseDate { get; set; }
        public DateTime PrenatalBaseDate { get; set; }
        public DateTime SourceTime { get; set; }
        public SourceType SourceType { get; set; }
        public string SourceKey { get; set; }
        public List<GroupContact> Groups { get; set; }
    }
}
