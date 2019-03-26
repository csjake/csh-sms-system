using Microsoft.EntityFrameworkCore;
using ScheduleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheduleDataMigrationRoutines
{
    public class LanguagesSeed
    {
        static public void SeedOrUpdate(DbSet<Language> Items)
        {
            string[] items = { "English", "Hindi" };
            var currentItemLookup = Items.ToDictionary(prop => prop.Name);
            var targetItemLookup = new HashSet<string>(items);

            //add missing
            items.ToList().ForEach(prop => {
                if (!currentItemLookup.ContainsKey(prop))
                {
                    Items.Add(new Language { Name = prop });
                }
            });

            //remove old
            var currentItems = Items.ToList();
            currentItems.ForEach(prop =>
            {
                if (!targetItemLookup.Contains(prop.Name))
                {
                    Items.Remove(prop);
                }
            });
        }
    }
}
