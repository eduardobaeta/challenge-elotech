using Challenge.Data.Repositories.Interfaces;
using Challenge.Domain.Entities;

namespace Challenge.Data.Repositories;

public class ContactRepository : IContactRepository
{
    public Task<Contact?> GetContactById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Contact>> GetContactsByClientId(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Contact?> InsertContactAsync(Contact contact)
    {
        throw new NotImplementedException();
    }
}