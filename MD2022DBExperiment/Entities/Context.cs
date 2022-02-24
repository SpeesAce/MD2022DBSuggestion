using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD2022DBExperiment.Entities
{
    public class Context : IdentityDbContext<IdentityUser>
    {
        //Constructor called by startup----------------------------------------------
        public Context(DbContextOptions<Context> options) : base(options) { }

        //Tables---------------------------------------------------------------------
        //public DbSet<Administrators> Admins { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet<GroupLeaders> Groupleaders { get; set; }

        //public DbSet<Members> GroupMembers { get; set; }

        public DbSet<Groups> Groups { get; set; }

        public DbSet<GroupMembers> GroupMembers { get; set; }

        //public DbSet<Organisations> Organisations { get; set; }

        //public DbSet<Speakers> Speakers { get; set; }

        public DbSet<Workshops> Workshops { get; set; }

        public DbSet<SpeakerAllocations> SpeakerAllocations { get; set; }

        public DbSet<Locations> Locations { get; set; }

        public DbSet<Timeslots> Timeslots { get; set; }

        public DbSet<WorkshopInvitations> WorkshopInvitations { get; set; }

        public DbSet<Registrations> Registrations { get; set; }

        //Additional constraints-----------------------------------------------------
        protected override void OnModelCreating(ModelBuilder builder)
        {
                    

            

            

        }
    }
}
