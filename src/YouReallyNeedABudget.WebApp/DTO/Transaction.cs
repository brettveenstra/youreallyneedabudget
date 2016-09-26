using System;

namespace YouReallyNeedABudget.WebApp.DTO
{

    public class Transaction
    {
        public int ID;
        public string PayeeName;
        public DateTime Date;
        public string Memo;
        public decimal Amount;
        public bool Cleared;
        public int AccountId;
    }
}
