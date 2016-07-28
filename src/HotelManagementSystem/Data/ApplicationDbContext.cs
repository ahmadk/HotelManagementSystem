using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem.Models;
using HotelManagementSystem.Data.UserDefinedClasses;

namespace HotelManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Code> Codes { get; set; }
        public DbSet<Codeset> Codesets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerFee> CustomerFees { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomCheck> RoomChecks { get; set; }
        public DbSet<RoomDescription> RoomDescriptions { get; set; }
        public DbSet<RoomFee> RoomFees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Code>(f => f.HasKey(g => g.ID));
            builder.Entity<Codeset>(f => f.HasKey(g => g.ID));
            builder.Entity<Customer>(f => f.HasKey(g => g.ID));
            builder.Entity<CustomerFee>(f => f.HasKey(g => g.ID));
            builder.Entity<Employee>(f => f.HasKey(g => g.ID));
            builder.Entity<Fee>(f => f.HasKey(g => g.ID));
            builder.Entity<Reservation>(f => f.HasKey(g => g.ID));
            builder.Entity<Room>(f => f.HasKey(g => g.ID));
            builder.Entity<RoomCheck>(f => f.HasKey(g => g.ID));
            builder.Entity<RoomDescription>(f => f.HasKey(g => g.ID));
            builder.Entity<RoomFee>(f => f.HasKey(g => g.ID));

            builder.Entity<Code>().Property(f => f.CodesetID).IsRequired();

            builder.Entity<Customer>().Property(f => f.Name).IsRequired();
            builder.Entity<Customer>().Property(f => f.Lastname).IsRequired();
            builder.Entity<Customer>().Property(f => f.Phone).IsRequired();
            builder.Entity<Customer>().Property(f => f.Email).IsRequired();

            builder.Entity<CustomerFee>().Property(f => f.CustomerID).IsRequired();
            builder.Entity<CustomerFee>().Property(f => f.ReservationID).IsRequired();

            builder.Entity<Employee>().Property(f => f.EmployeeTypeID).IsRequired();

            builder.Entity<Reservation>().Property(f => f.RegistrationDate).IsRequired();
            builder.Entity<Reservation>().Property(f => f.EntryDate).IsRequired();
            builder.Entity<Reservation>().Property(f => f.ExitDate).IsRequired();
            builder.Entity<Reservation>().Property(f => f.CustomerID).IsRequired();
            builder.Entity<Reservation>().Property(f => f.RoomID).IsRequired();

            builder.Entity<Room>().Property(f => f.RoomNo).IsRequired();
            builder.Entity<Room>().Property(f => f.Floorno).IsRequired();

            builder.Entity<RoomCheck>().Property(f => f.ReservationId).IsRequired();

            builder.Entity<RoomDescription>().Property(f => f.RoomTypeID).IsRequired();
           
            builder.Entity<RoomFee>().Property(f => f.RoomID).IsRequired();

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
