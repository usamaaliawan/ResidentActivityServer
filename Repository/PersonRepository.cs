using Entities.Models;
using Contracts;
using Entities;

namespace Repository
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Person> PersonInRoom(Guid personId)
        {
            return FindByCondition(a => a.Id.Equals(personId)).ToList();
        }
    }
}
