using BudgetTracker.models;
using BudgetTracker.Models;
using BudgetTrackerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetTracker.Context
{
    public class Applicationdbcontext:DbContext
    {
        public Applicationdbcontext(DbContextOptions<Applicationdbcontext> options):base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Income> Income { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<Category> Category{ get; set; }
        public DbSet<Savings> Savings{ get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Customer>()
        //        .HasMany(u => u.Income)
        //        .WithOne(i => i.User)
        //        .HasForeignKey(i => i.UserId);

        //    modelBuilder.Entity<Customer>()
        //        .HasMany(u => u.Expense)
        //        .WithOne(e => e.User)
        //        .HasForeignKey(e => e.UserId);
        //}


    }
}
