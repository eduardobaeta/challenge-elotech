using Challenge.Domain.Entities;

namespace Challenge.Data.Repositories.Interfaces;

public interface IClientRepository
{
    Task<IList<Client>> GetClients();
    Task<Client?> GetClientById (Guid id);
    Task<Client?> InsertClientAsync (Client client);
}