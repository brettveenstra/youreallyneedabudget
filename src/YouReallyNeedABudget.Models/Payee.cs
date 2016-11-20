using System.ComponentModel.DataAnnotations;

namespace YouReallyNeedABudget.Models
{
    public class Payee
    {
        [Key]
        public string Name { get; set; }
    }
}
