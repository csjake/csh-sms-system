﻿using System;
using Microsoft.EntityFrameworkCore;
using ScheduleModel;
namespace ScheduleModel
{
    public class ScheduleDbContext : DbContext
    {         
        public ScheduleDbContext(DbContextOptions options) :base (options)
        {}        
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<MessageStub> MessageStubs { get; set; }
        public virtual DbSet<ScheduleItem> ScheduleItems { get; set; }
        public virtual DbSet<ScheduleItemReminder> ScheduleItemReminders { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<ContactProperty> ContactProperties { get; set; }
        public virtual DbSet<MessageImplementation> MessageImplementations { get; set; }
    }
}
