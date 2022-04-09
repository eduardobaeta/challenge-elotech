using Challenge.Domain.Entities;

namespace Challenge.Data.Repositories.Interfaces;

public interface IClientRepository
{
    Task<List<Client>> GetClients();
    Task<Client?> GetClientById (Guid id);
    Task<Client?> InsertClientAsync (Client client);
}