
using System.Collections.Generic;

namespace YouReallyNeedABudget.WebApp.DTO
{
    public class Account
    {
        public int ID;
        public int LogId;
        public string Name;
        public string Type;
        public ICollection<Transaction> Transactions;
    }
}
