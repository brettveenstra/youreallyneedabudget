using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace YouReallyNeedABudget.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public int AccountId { get; set; }
        [ForeignKey("Payee")]
        public string PayeeName { get; set; }
        public DateTime Date { get; set; }
        public string Memo { get; set; }
        public decimal Amount { get; set; }
        public bool Cleared { get; set; }
        public Account Account { get; set; }
        public Payee Payee { get; set; }
    }
}
