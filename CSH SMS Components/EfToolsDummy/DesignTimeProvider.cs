using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MasterDatabase;
namespace EFToolsDummy
{
    //this is used by "Add-Migration"
    public class DesignTimeProvider : IDesignTimeDbContextFactory<MasterDatabaseContext>
    {
        public MasterDatabaseContext CreateDbContext(string[] args)
        {
            return MasterDatabaseContext.CreateDevDB();
        }
    }
}
