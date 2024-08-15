using BudgetTracker.Context;
using BudgetTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ExpenseController : ControllerBase
{
    private readonly Applicationdbcontext _context;

    public ExpenseController(Applicationdbcontext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AddExpense(Expense expense)
    {
        _context.Expense.Add(expense);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("{userId}")]
    public IActionResult GetExpenses(int userId)
    {
        var expenses = _context.Expense.Where(e => e.UserId == userId).ToList();
        return Ok(expenses);
    }

    [HttpGet("categories/{userId}")]
    public IActionResult GetCategories(int userId)
    {
        var categories = _context.Expense
            .Where(e => e.UserId == userId)
            .GroupBy(e => e.Category)
            .Select(g => new { Category = g.Key, Total = g.Sum(e => e.Amount) })
            .ToList();
        return Ok(categories);
    }
}