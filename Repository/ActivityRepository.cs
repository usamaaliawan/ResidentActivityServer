using Entities.Models;
using Contracts;
using Entities;

namespace Repository
{
    public class ActivityRepository : RepositoryBase<Activity>, IActivityRepository
    {
        public ActivityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
