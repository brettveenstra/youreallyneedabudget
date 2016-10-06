using System.Collections.Generic;

namespace YouReallyNeedABudget.WebApi.DTO
{
    public class Log
    {
        public int ID;
        public string Name;
        public ICollection<Account> Accounts;
    }

}
