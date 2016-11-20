using System.Linq;
using YouReallyNeedABudget.Models;

namespace YouReallyNeedABudget.DataAccess
{
    public class TransactionRepository : ITransactionRepository
    {
        BudgetContext _dbContext;

        public TransactionRepository(BudgetContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Transaction transaction)
        {
            if (string.IsNullOrEmpty(transaction.PayeeName) == false)
            {
                if (_dbContext.Payees.SingleOrDefault(p => p.Name == transaction.PayeeName) == null)
                {
                    _dbContext.Payees.Add(new Payee { Name = transaction.PayeeName });
                }
            }

            _dbContext.Transactions.Add(transaction);
            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            _dbContext.Transactions.Remove(_dbContext.Transactions.Where(tx => tx.ID == id).SingleOrDefault());
            _dbContext.SaveChanges();
        }

    }
}
