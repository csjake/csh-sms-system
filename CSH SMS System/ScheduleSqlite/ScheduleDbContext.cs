using System;
using Microsoft.EntityFrameworkCore;
using ScheduleModel;
namespace ScheduleSqlite
{
    public class ScheduleDbContext : DbContext
    {

        string _connectionString;
        public ScheduleDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(_connectionString);
            }
        }

        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<MessageTemplate> MessageTempaltes { get; set; }
        public virtual DbSet<ScheduleItem> ScheduleItems { get; set; }
        
    }
}
