using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouReallyNeedABudget.Models;

namespace YouReallyNeedABudget.DataAccess
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BudgetContext _dbContext;

        public AccountRepository(BudgetContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Account account)
        {
            _dbContext.Accounts.Add(account);
            _dbContext.SaveChanges();
        }

        public Account Get(int id)
        {
            return _dbContext.Accounts.Single(account => account.ID == id);
        }

        public IEnumerable<Account> GetAll()
        {
            return _dbContext.Accounts.ToList();
        }
    }
}
