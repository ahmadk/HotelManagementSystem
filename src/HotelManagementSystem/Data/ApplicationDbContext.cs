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
            builder.Entity<Customer>().HasAlternateKey(k => k.Email);

            builder.Entity<Customer>().HasIndex(a => a.ID).IsUnique();
            builder.Entity<Customer>().HasIndex(b => b.ReservationID).IsUnique();

            builder.Entity<Customer>().Property(b => b.Lastname).IsConcurrencyToken();

            builder.Entity<Customer>().Property(p => p.ID).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            builder.Entity<Customer>().Property(b => b.Name).HasMaxLength(500);
            builder.Entity<Customer>().Property(b => b.Lastname).HasMaxLength(500);
            builder.Entity<Customer>().Property(b => b.Phone).HasMaxLength(500);
            builder.Entity<Customer>().Property(b => b.Address).HasMaxLength(500);
            builder.Entity<Customer>().Property(b => b.Email).HasMaxLength(500);

            builder.Entity<Customer>().Property(c => c.ID).IsRequired();
            builder.Entity<Customer>().Property(c => c.ReservationID).IsRequired();
            builder.Entity<Customer>().Property(c => c.Name).IsRequired();
            builder.Entity<Customer>().Property(c => c.Lastname).IsRequired();
            builder.Entity<Customer>().Property(c => c.Phone).IsRequired();
            builder.Entity<Customer>().Property(c => c.Address).IsRequired();
            builder.Entity<Customer>().Property(c => c.Email).IsRequired();


            builder.Entity<Customer>().HasKey(c => new { c.ReservationID });

            builder.Entity<Customer>().Property(b => b.ID).ValueGeneratedNever();
            builder.Entity<Customer>().Property(b => b.ID).ValueGeneratedOnAdd();
            builder.Entity<Customer>().Property(b => b.ID).ValueGeneratedOnAddOrUpdate();


            builder.Entity<Customer>().Property(b => b.ReservationID).ValueGeneratedNever();
            builder.Entity<Customer>().Property(b => b.ReservationID).ValueGeneratedOnAdd();
            builder.Entity<Customer>().Property(b => b.ReservationID).ValueGeneratedOnAddOrUpdate();

            builder.Entity<Customer>().Property(b => b.Name).ValueGeneratedNever();
            builder.Entity<Customer>().Property(b => b.Name).ValueGeneratedOnAdd();
            builder.Entity<Customer>().Property(b => b.Name).ValueGeneratedOnAddOrUpdate();

            builder.Entity<Customer>().Property(b => b.Lastname).ValueGeneratedNever();
            builder.Entity<Customer>().Property(b => b.Lastname).ValueGeneratedOnAdd();
            builder.Entity<Customer>().Property(b => b.Lastname).ValueGeneratedOnAddOrUpdate();

            builder.Entity<Customer>().Property(b => b.Phone).ValueGeneratedNever();
            builder.Entity<Customer>().Property(b => b.Phone).ValueGeneratedOnAdd();
            builder.Entity<Customer>().Property(b => b.Phone).ValueGeneratedOnAddOrUpdate();

            builder.Entity<Customer>().Property(b => b.Address).ValueGeneratedNever();
            builder.Entity<Customer>().Property(b => b.Address).ValueGeneratedOnAdd();
            builder.Entity<Customer>().Property(b => b.Address).ValueGeneratedOnAddOrUpdate();

            builder.Entity<Customer>().Property(b => b.Email).ValueGeneratedNever();
            builder.Entity<Customer>().Property(b => b.Email).ValueGeneratedOnAdd();
            builder.Entity<Customer>().Property(b => b.Email).ValueGeneratedOnAddOrUpdate();

            //

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
