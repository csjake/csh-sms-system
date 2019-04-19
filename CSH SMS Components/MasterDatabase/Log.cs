using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDatabase
{
    public class Log
    {
        public int Id { get; set; }
        public string Operation { get; set; }
        public List<LogReferences> References {get;set;}
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }        
    }
}
