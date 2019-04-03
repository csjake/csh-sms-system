using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleSystem
{
    public interface IController<TItem, TKey>
    {
        TItem Get(TKey id);
        TItem Add();
        void Update(TItem item);
        void Delete(TKey id);
    }
    public interface IController<TItem> : IController<TItem, int>   {}
}
