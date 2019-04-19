using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDatabase
{
    public class SyncInfo
    {
        public SyncInfo(DateTime syncStartTime, DateTime syncEndTime, string syncType, DateTime setMinDate, DateTime setMaxDate)
        {
            this.SyncStartTime = syncStartTime;
            this.SyncEndTime = syncEndTime;
            this.SyncType = syncType;
            this.SetMinDate = setMinDate;
            this.SetMaxDate = setMaxDate;
        }
        public int Id { get; set; }
        public DateTime SyncStartTime { get; set; }
        public DateTime SyncEndTime { get; set; }

        public string SyncType { get; set; }
        public DateTime SetMinDate { get; set; }
        public DateTime SetMaxDate { get; set; }
    }
}
