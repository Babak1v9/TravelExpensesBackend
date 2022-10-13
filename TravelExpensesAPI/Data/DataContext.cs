using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TravelExpensesAPI.Models;

namespace TravelExpensesAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<User> Users { get; set; }  
        public DbSet<Address> Address { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; }
        public DbSet<TravelReason> TravelReasons { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<AdditionalCost> AdditionalCost { get; set; }
        public DbSet<Approval> Approvals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Application>()
                .HasOne(r => r.StartAddress)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Application>()
                .HasOne(r => r.EndAddress)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
