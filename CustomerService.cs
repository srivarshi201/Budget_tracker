using BudgetTracker.Context;
using BudgetTracker.models;
using BudgetTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetTracker.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly Applicationdbcontext _dbContext;

        public CustomerService(Applicationdbcontext applicationdbcontext)
        {
            _dbContext = applicationdbcontext;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            var details = new Customer
            {
                Id = customer.Id,
                Email = customer.Email,
                Password = customer.Password,
                Username = customer.Username,
            };
            var result = await _dbContext.Customers.AddAsync(details);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<string> LogIn(string email, string password)
        {
            var details = await _dbContext.Customers.FirstOrDefaultAsync(x=>x.Email == email && x.Password == password);
            if (details == null)
            {
                return "user are not found";
            }
            return "User login succesfull";
        }

        public async Task<Income> CreateIncome(Income income)
        {
            var details = new Income
            {
                IncomeId = income.IncomeId,
                UserId = income.UserId,
                Source = income.Source,
                Amount = income.Amount,
                Date = income.Date
            };
            var result = await _dbContext.Income.AddAsync(details);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
