
using BudgetTracker.Context;
using BudgetTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class IncomeController : ControllerBase
{
    private readonly Applicationdbcontext _context;

    public IncomeController(Applicationdbcontext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AddIncome(Income income)
    {
        _context.Income.Add(income);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("{userId}")]
    public IActionResult GetIncomes(int userId)
    {
        var incomes = _context.Income.Where(i => i.UserId == userId).ToList();
        return Ok(incomes);
    }
}
