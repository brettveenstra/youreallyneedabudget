using System.Collections.Generic;

namespace YouReallyNeedABudget.Models
{
    public class Payee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
