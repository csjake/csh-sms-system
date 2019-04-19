using MasterDatabase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SyncBase
{
    public abstract class Sync<TSource, TDest> where TSource:class where TDest:class
    {
        protected MasterDatabaseContext dbContext;

        public Sync(MasterDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Log LogStart(string operation)
        {
            var log = new Log() { StartTime = DateTime.Now, Operation = operation };
            dbContext.Set<Log>().Add(log);
            dbContext.SaveChanges();
            return log;
        }

        public void SaveLog(Log log)
        {
            if (log.EndTime.HasValue == false)
            {
                log.EndTime = DateTime.Now;
            }
            dbContext.Set<Log>().Attach(log);
            dbContext.SaveChanges();
        }

        public SyncInfo GetSyncInfo()
        {
            var syncType = typeof(TDest).Name;

            var x = (from syncInfo in dbContext.SyncInfos
                     where syncInfo.SyncType == syncType
                     orderby syncInfo.Id descending
                     select syncInfo).First();
            return x;
        }
        public abstract List<TSource> GetNewSourceData(SyncInfo sync);
        public abstract List<TDest> TransformSourceToDest(List<TSource> newSourceData);
        public bool SaveNewDestData(List<TDest> newDestData)
        {
            dbContext.Set<TDest>().AddRange(newDestData);
            dbContext.SaveChanges();
            return true;
        }
        public abstract SyncInfo CreateNewSyncInfo(DateTime startTime, List<TDest> newDestData);
        public bool SaveNewSyncInfo(SyncInfo sync)
        {
            dbContext.Set<SyncInfo>().Add(sync);
            dbContext.SaveChanges();
            return true;
        }
    }
}
