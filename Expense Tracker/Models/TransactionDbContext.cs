using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options) 
        {}

        public DbSet<Transaction>Transactions { get; set; }

    }
}
