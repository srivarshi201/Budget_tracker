using BudgetTracker.models;
using System.ComponentModel.DataAnnotations;

namespace BudgetTracker.Models
{
    public class Income
    {
        [Key]
        public int IncomeId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }

        
    }
}
