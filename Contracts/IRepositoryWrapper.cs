using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IRoomRepository Room { get; }
        
        IPersonRepository Person { get; }
        IActivityRepository Activity { get; }
        IPersonActivityRepository PersonActivity { get; }
        IExpenseRepository Expense { get; }
        void Save();
    }
}
