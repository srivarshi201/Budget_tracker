using BudgetTracker.models;
using System.ComponentModel.DataAnnotations;

namespace BudgetTracker.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        
    }
}
