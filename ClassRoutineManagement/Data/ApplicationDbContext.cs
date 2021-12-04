using ClassRoutineManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoutineManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
             
        }
        public virtual DbSet<ClassRoutine> ClassRoutines { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<ClassRoom> ClassRooms { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Teacher>().HasMany(e => e.ClassRoutines).WithOne(e => e.Teacher).OnDelete(DeleteBehavior.NoAction);
        //    //modelBuilder.Entity<Apartment>().HasMany(e => e.ViewUnitStatuses).WithOne(e => e.Apartment).OnDelete(DeleteBehavior.NoAction);
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
