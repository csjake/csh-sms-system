using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScheduleModel;
using ScheduleSystem;

namespace ScheduleSystemTests
{
    [TestClass]
    public class ScheduleTests
    {
        private Host _host;

        [TestInitialize]
        public void TestInit()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ScheduleDbContext>();
            optionsBuilder.UseSqlite("DataSource=:memory:");
            _host = new Host(optionsBuilder.Options);
        }

        [TestMethod]
        public void TestScheduleProviderAdd()
        {
            var scheduleController = _host.Get<ScheduleController>();
            var contactPropertyController = _host.Get<ContactPropertyController>();
            scheduleController.Add("test", 1);
        }
    }
}
