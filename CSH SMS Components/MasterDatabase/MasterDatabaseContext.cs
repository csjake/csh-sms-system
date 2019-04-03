using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace MasterDatabase
{
    public class MasterDatabaseContext : DbContext
    {
        public MasterDatabaseContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupContact> GroupContacts { get; set; }
        public DbSet<SourceType> SourceTypes { get; set; }
        public DbSet<TelerivetContact> TelerivetContact { get; set; }
    }
}
