using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ScheduleModel;

namespace ScheduleDataMigrationRoutines
{
    public class ContactPropertySeed
    {
        static public void SeedOrUpdate(DbSet<ContactProperty> Items)
        {
            string[] items = { nameof(Contact.MmrDate), nameof(Contact.PentaDate), nameof(Contact.PrenatalDate) };
            var currentItemLookup = Items.ToDictionary(prop => prop.Name);
            var targetItemLookup = new HashSet<string>(items);

            //add missing
            items.ToList().ForEach(prop => {
                if (!currentItemLookup.ContainsKey(prop))
                {
                    Items.Add(new ContactProperty { Name = prop });
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
