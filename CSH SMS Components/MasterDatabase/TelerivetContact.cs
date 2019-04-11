using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDatabase
{
    public class TelerivetContact
    {
        public string Id { get; set; }
        public bool SendBlocked { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime? LastContacted { get; set; }
        public DateTime? LastHeardFrom { get; set; }
        public int OutgoingMessageCount { get; set; }
        public int IncomingMessageCount { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string ProjectId { get; set; }
        public string GroupIds { get; set; }

        public string MotherName { get; set; }
        public string ChildName { get; set; }
        public DateTime? MmrBaseDate { get; set; }
        public DateTime? PentaBaseDate { get; set; }
        public DateTime? PrenatalBaseDate { get; set; }

        public DateTime SourceDate { get; set; }
        public string SourceType { get; set; }
        public string SourceKey { get; set; }       
    }
}
