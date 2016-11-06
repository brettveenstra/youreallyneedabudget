using YouReallyNeedABudget.Models;

namespace YouReallyNeedABudget.DataAccess
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
        void Remove(int id); 
    }
}
