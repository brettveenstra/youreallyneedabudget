
using System.Collections.Generic;

namespace YouReallyNeedABudget.Models
{
    public class Log
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }


}
