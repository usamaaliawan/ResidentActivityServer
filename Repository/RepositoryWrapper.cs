using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IRoomRepository _room;
        private IPersonRepository _person;
        private IActivityRepository _activity;
        private IPersonActivityRepository _personActivity;
        private IExpenseRepository _expense;
        public IRoomRepository Room
        {
            get
            {
                if (_room == null)
                {
                    _room = new RoomRepository(_repoContext);
                }
                return _room;
            }
        }
        

        public IPersonRepository Person
        {
            get
            {
                if (_person == null)
                {
                    _person = new PersonRepository(_repoContext);
                }
                return _person;
            }
        }

        public IActivityRepository Activity
        {
            get
            {
                if (_activity == null)
                {
                    _activity = new ActivityRepository(_repoContext);
                }
                return _activity;
            }
        }

        public IPersonActivityRepository PersonActivity
        {
            get
            {
                if (_personActivity == null)
                {
                    _personActivity = new PersonActivityRepository(_repoContext);
                }
                return _personActivity;
            }
        }

        public IExpenseRepository Expense
        {
            get
            {
                if (_expense == null)
                {
                    _expense = new ExpenseRepository(_repoContext);
                }
                return _expense;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
