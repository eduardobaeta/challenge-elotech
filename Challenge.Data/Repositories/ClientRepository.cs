using Challenge.Data.Context;
using Challenge.Data.Repositories.Interfaces;
using Challenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Data.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly SqlContext _context;


    public ClientRepository(SqlContext context)
    {
        _context = context;
    }

    public async Task<List<Client>> GetClients()
    {
        var clients = await _context.Clients.AsNoTracking().ToListAsync();
        return clients;
    }

    public async Task<Client?> GetClientById(Guid id)
    {
        var client = await _context.Clients.FirstOrDefaultAsync(x => x.Id == id);
        return client;
    }

    public async Task<Client?> InsertClientAsync(Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
        return client;
    }
}