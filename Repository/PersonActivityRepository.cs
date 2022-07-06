using Entities.Models;
using Contracts;
using Entities;

namespace Repository
{
    public class PersonActivityRepository : RepositoryBase<PersonActivity>, IPersonActivityRepository
    {
        public PersonActivityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
