using System;

namespace YouReallyNeedABudget.WebApi.DTO
{

    public class Transaction
    {
        public int ID;
        public int AccountId;
        public DateTime Date;
        public int? PayeeId;
        public string Memo;
        public decimal Amount;
        public bool Cleared;
    }
}
