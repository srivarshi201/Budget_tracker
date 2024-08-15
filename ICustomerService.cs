using BudgetTracker.models;
using BudgetTracker.Models;

namespace BudgetTracker.Services
{
    public interface ICustomerService
    {
        Task<Customer> CreateCustomer(Customer customer);
        Task<Income> CreateIncome(Income income);
        Task<string> LogIn(string email, string password);
    }
}