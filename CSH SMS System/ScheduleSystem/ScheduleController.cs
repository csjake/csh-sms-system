using System;
using ScheduleModel;
using System.Linq;
namespace ScheduleSystem
{
    public class ScheduleController : BaseController<Schedule>
    {
        public ScheduleController(Host host): base(host)
        {
        }

        public Schedule Add(string name, int contactPropertyId)
        {
            using (var db = _host.GetDb())
            {
                var cp = db.ContactProperties.Find(new object[] { contactPropertyId });
                var schedule = new Schedule { Name = name, ContactProperty = cp };
                db.Schedules.Add(schedule);
                return schedule;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }        

        public void Update(int id, string name, int contactPropertyId)
        {
            var schedule = Get(id);
            schedule.Name = name;
            schedule.ContactProperty = _host.Get<ContactPropertyController>().Get(id);
        }
    }
}