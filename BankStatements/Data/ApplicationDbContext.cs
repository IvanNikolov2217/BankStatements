using BankStatements.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BankStatements.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Statement> Statements { get; set; }

        public DbSet<ExchangeType> ExchangeTypes { get; set; }

        public DbSet<TransactionType> TransactionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ExchangeType>().HasData(new ExchangeType { Id = 1, Name = "Income" });
            builder.Entity<ExchangeType>().HasData(new ExchangeType { Id = 2, Name = "Expense" });

            builder.Entity<TransactionType>().HasData(new TransactionType { Id = 1, Name = "Payment" });
            builder.Entity<TransactionType>().HasData(new TransactionType { Id = 2, Name = "Invoice" });
            builder.Entity<TransactionType>().HasData(new TransactionType { Id = 3, Name = "Other payment" });

            base.OnModelCreating(builder);
        }
    }
}