using Challenge.Domain.Entities;

namespace Challenge.Data.Repositories;

public interface IClientRepository
{
    public Task<Client> GetClients { get; set; }
    public Task<Client?> GetClientById { get; set; }
    public Task<Client?> InsertClientAsync { get; set; }
}