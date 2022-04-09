using Challenge.Domain.Entities;

namespace Challenge.Data.Repositories.Interfaces;

public interface IContactRepository
{
    Task<Contact?> GetContactById(Guid id);
    Task<IList<Contact>> GetContactsByClientId(Guid id);
    Task<Contact?> InsertContactAsync (Contact contact);
}