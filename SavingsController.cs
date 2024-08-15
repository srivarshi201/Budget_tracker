using BudgetTracker.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class SavingsController : ControllerBase
{
    private readonly Applicationdbcontext _context;

    public SavingsController(Applicationdbcontext context)
    {
        _context = context;
    }

    [HttpGet("{userId}")]
    public IActionResult GetSavings(int userId)
    {
        var totalIncome = _context.Income.Where(i => i.UserId == userId).Sum(i => i.Amount);
        var totalExpense = _context.Expense.Where(e => e.UserId == userId).Sum(e => e.Amount);

        var savings = totalIncome - totalExpense;

        return Ok(savings);
    }
}