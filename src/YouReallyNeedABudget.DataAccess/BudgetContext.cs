using Microsoft.EntityFrameworkCore;
using YouReallyNeedABudget.Models;

namespace YouReallyNeedABudget.DataAccess
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options)
        {
        }

        public BudgetContext() { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Payee> Payees { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Transaction>().ToTable("Transaction");
            modelBuilder.Entity<Payee>().ToTable("Payee");
            modelBuilder.Entity<Log>().ToTable("Log");
        }
    }
}
