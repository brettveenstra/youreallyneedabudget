
using System.Collections.Generic;

namespace YouReallyNeedABudget.Models
{
    public class Account
    {
        public int ID { get; set; }
        public int LogId { get; set; }
        public string Name { get; set; }
        public AccountType Type { get; set; }
        public Log Log { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
