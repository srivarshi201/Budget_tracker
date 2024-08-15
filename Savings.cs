using System.ComponentModel.DataAnnotations;

namespace BudgetTrackerApi.Models
{
    public class Savings
    {
        [Key]
        public int SavingsId { get; set; }
        public int UserId { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal TotalSavings { get; set; }
        public DateTime CalculatedDate { get; set; }
    }
}