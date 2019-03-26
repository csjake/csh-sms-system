using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ScheduleSqlite;
namespace EFToolsDummy
{
    public class DesignTimeProvider : IDesignTimeDbContextFactory<ScheduleDbContext>
    {
        public ScheduleDbContext CreateDbContext(string[] args)
        {
            return new ScheduleDbContext("DesignTime.db");
        }
    }
}
