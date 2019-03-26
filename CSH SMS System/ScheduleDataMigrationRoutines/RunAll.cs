using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleDataMigrationRoutines
{
    public class RunAll
    {
        static void Run(ScheduleModel.ScheduleDbContext db)
        {
            LanguagesSeed.SeedOrUpdate(db.Languages);
            ContactPropertySeed.SeedOrUpdate(db.ContactProperties);
        }
    }
}
