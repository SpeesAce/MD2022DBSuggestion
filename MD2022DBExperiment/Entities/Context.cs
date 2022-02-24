using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    public class Context : IdentityDbContext<AppUser>
    {
        //Constructor called by startup----------------------------------------------
        public Context(DbContextOptions<Context> options) : base(options) { }

        //Tables---------------------------------------------------------------------
        //public DbSet<Administrators> Admins { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet<GroupLeaders> Groupleaders { get; set; }

        public DbSet<GroupMembers> GroupMembers { get; set; }

        public DbSet<Groups> Groups { get; set; }

        //public DbSet<Organisations> Organisations { get; set; }

        public DbSet<Speakers> Speakers { get; set; }

        public DbSet<Workshops> Workshops { get; set; }

        public DbSet<SpeakerAllocations> SpeakerAllocations { get; set; }

        public DbSet<Locations> Locations { get; set; }

        public DbSet<Timeslots> Timeslots { get; set; }

        public DbSet<WorkshopInvitations> WorkshopInvitations { get; set; }

        public DbSet<Registrations> Registrations { get; set; }

        //Additional constraints-----------------------------------------------------
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GroupLeaders>()
                .HasIndex(p => p.Email)
                .IsUnique();
            base.OnModelCreating(builder);

            builder.Entity<GroupMembers>()
                .HasIndex(p => p.Email)
                .IsUnique();
            base.OnModelCreating(builder);

            builder.Entity<Speakers>()
                .HasIndex(e => e.Email)
                .IsUnique();
            base.OnModelCreating(builder);

            //Default values----------------------------------------------------------
            builder.Entity<GroupLeaders>()
                .Property(b => b.Approved)
                .HasDefaultValueSql("0");

            builder.Entity<WorkshopInvitations>()
                .Property(b => b.Accepted)
                .HasDefaultValueSql("0");

            builder.Entity<WorkshopInvitations>()
                .Property(b => b.TimeStamp)
                .HasDefaultValueSql("getDate()");

            builder.Entity<Registrations>()
                .Property(b => b.Timestamp)
                .HasDefaultValueSql("getDate()");

        }
    }
}
