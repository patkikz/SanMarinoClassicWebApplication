using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SanMarinoClassicWebsite.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Pie> Pies { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<Pie>()
            //    .HasOne(p => p.RecipeInformation)
            //    .WithOne(i => i.Pie)
            //    .HasForeignKey<RecipeInformation>(b => b.PieId);

            builder.Entity<ApplicationUser>()
                .HasMany(e => e.Claims)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<EquipmentType> EquipmentTypes { get; set; }

        public DbSet<MonthlyDue> Dues { get; set; }

        public DbSet<MonthlyDueRecord> MonthlyDues { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Payment> Payments { get; set; }    
    }

  
}
