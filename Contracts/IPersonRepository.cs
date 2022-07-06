using Entities.Models;

namespace Contracts
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        IEnumerable<Person> PersonInRoom(Guid personId);
    }
}
