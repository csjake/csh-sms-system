using MasterDatabase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyncBase
{
    public class SyncPerformer<TSource, TDest> where TSource : class where TDest : class
    {
        protected DbContext dbContext;
        public SyncPerformer(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public TResult Perform<TResult>(Sync<TSource, TDest> sync, Func<TResult> func, string operation)
        {
            var log = sync.LogStart(operation);
            try
            {
                var result = func();
                return result;
            }
            catch (Exception ex)
            {
                log.EndTime = DateTime.Now;
                sync.SaveLog(log);
                throw;
            }
        }
        
        public void PerformSync(Sync<TSource, TDest> sync)
        {
            var startTime = DateTime.Now.ToUniversalTime();
            var syncInfo = Perform(sync, () => sync.GetSyncInfo(), nameof(sync.GetSyncInfo));
            var newSourceData = Perform(sync, () => sync.GetNewSourceData(syncInfo), nameof(sync.GetNewSourceData));
            var newDestData = Perform(sync, () => sync.TransformSourceToDest(newSourceData), nameof(sync.TransformSourceToDest));
            var saved = Perform(sync, () => sync.SaveNewDestData(newDestData), nameof(sync.SaveNewDestData));
            var newSyncInfo = Perform(sync, () => sync.CreateNewSyncInfo(startTime, newDestData), nameof(sync.CreateNewSyncInfo));
            saved = Perform(sync, () => sync.SaveNewSyncInfo(newSyncInfo), nameof(sync.SaveNewSyncInfo));
        }
    }
}
