using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MasterDatabase
{
    public class MasterDatabaseContext : DbContext
    {
        public MasterDatabaseContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Log> Logs { get; set; }
        public DbSet<SyncInfo> SyncInfos { get; set; }
        public DbSet<LogReferences> LogReferences { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupContact> GroupContacts { get; set; }
        //public DbSet<SourceType> SourceTypes { get; set; }

        public DbSet<TelerivetContact> TelerivetContacts { get; set; }
        public DbSet<TelerivetGroup> TelerivetGroups { get; set; }

        public DbSet<TelerivetContactV1> TelerivetContactV1s { get; set; }
        public DbSet<TelerivetGroupV1> TelerivetGroupV1s { get; set; }

        public DbSet<SCTOPartnerSurvey20190223> PartnerSurveys20190223 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            var converter = new ValueConverter<DateTime, long>(
                v => v.Ticks / 10000000 - 62135596800,
                v => new DateTime((v + 62135596800) * 10000000));

            modelBuilder.Entity<SCTOPartnerSurvey20190223>().HasKey(e => e.KEY);

            modelBuilder.Entity<GroupContact>()
                .HasKey(t => new { t.GroupId, t.ContactId });

            //modelBuilder.Entity<TelerivetContact>().Property(e => e.MmrBaseDate).HasConversion(converter);
            //modelBuilder.Entity<TelerivetContact>().Property(e => e.PentaBaseDate).HasConversion(converter);
            //modelBuilder.Entity<TelerivetContact>().Property(e => e.PrenatalBaseDate).HasConversion(converter);
            //modelBuilder.Entity<TelerivetContact>().Property(e => e.SourceDate).HasConversion(converter);
            //modelBuilder.Entity<TelerivetContact>().Property(e => e.TimeCreated).HasConversion(converter);

            //modelBuilder.Entity<TelerivetMessageV1>().Property(e => e.TimeCreated).HasConversion(converter);
            //modelBuilder.Entity<TelerivetMessageV1>().Property(e => e.TimeSent).HasConversion(converter);

        }

        public static MasterDatabaseContext CreateDevDB()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MasterDatabaseContext>();
            optionsBuilder.UseSqlite(@"DataSource=G:\Team Drives\Reporting_Restricted\CSH\Master\dev.db");

            var db = new MasterDatabaseContext(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }
    }
}
