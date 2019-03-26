using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ScheduleModel;
namespace EFToolsDummy
{
    public class DesignTimeProvider : IDesignTimeDbContextFactory<ScheduleDbContext>
    {
        public ScheduleDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ScheduleDbContext>();
            optionsBuilder.UseSqlite("DataSource=DesignTime.db");
            return new ScheduleDbContext(optionsBuilder.Options);
        }
    }
}
