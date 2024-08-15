using System.ComponentModel.DataAnnotations;

namespace BudgetTrackerApi.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}