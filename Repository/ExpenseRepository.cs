using Entities.Models;
using Contracts;
using Entities;

namespace Repository
{
    public class ExpenseRepository : RepositoryBase<Expense>, IExpenseRepository
    {
        public ExpenseRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
