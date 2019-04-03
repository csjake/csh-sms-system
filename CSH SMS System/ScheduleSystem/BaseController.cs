using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleSystem
{
    public class BaseController<T> where T:class
    {
        protected Host _host;
        public BaseController(Host host)
        {
            _host = host;
        }

        public T Get(int Id)
        {
            using (var db = _host.GetDb())
            {
                return _host.GetDb().Find<T>(new object[] { Id });
            }                
        }

        protected void Delete(T entity)
        {
            using (var db = _host.GetDb())
            {
                db.Set<T>().Remove(entity);
                db.SaveChanges();
            }
        }

        protected void Update(T entity)
        {
            using (var db = _host.GetDb())
            {
                db.Set<T>().Update(entity);                
                db.SaveChanges();
            }
        }
    }
}
