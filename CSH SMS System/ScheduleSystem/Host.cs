using System;
using Microsoft.EntityFrameworkCore;
using ScheduleModel;

namespace ScheduleSystem
{
    public class Host
    {
        private DbContextOptions<ScheduleDbContext> _dbContextOptions;
        public Host(DbContextOptions<ScheduleDbContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
            using (var db = GetDb())
            {
                ScheduleDataMigrationRoutines.ContactPropertySeed.SeedOrUpdate(db.ContactProperties);
                ScheduleDataMigrationRoutines.LanguagesSeed.SeedOrUpdate(db.Languages);
            }
        }

        static public Host GetTestHost()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ScheduleDbContext>();
            optionsBuilder.UseSqlite("DataSource=:memory:");
            return new Host(optionsBuilder.Options);
        }

        static public Host GetHost()
        {
            throw new NotImplementedException();
        }
      
        public ScheduleDbContext GetDb()
        {
            return new ScheduleDbContext(_dbContextOptions);
        }

        public T Get<T>() 
        {
            return (T)Activator.CreateInstance(typeof(T), this);
        }

        public ScheduleController GetScheduleController()
        {
            return new ScheduleController(this);
        }

        public ContactPropertyController GetContactPropertyController()
        {
            return new ContactPropertyController(this);
        }
    }
}
