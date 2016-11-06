using System.Collections.Generic;
using YouReallyNeedABudget.Models;

namespace YouReallyNeedABudget.DataAccess
{
    public interface IAccountRepository
    {
        Account Get(int id);
        IEnumerable<Account> GetAll();
        void Add(Account account);
    }
}
