using AutoMapper;
using OlympicFlights.DataAccess;
using OlympicFlights.DataAccess.ClientManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientDb = OlympicFlights.DataAccess.ClientManagement.Client;

namespace OlympicFlights.Service.ClientManagement
{
    public class ClientService: IClientService
    {
        private readonly IClientContext _clCtx;
        private readonly IMapper _mapper;

        public ClientService(IClientContext clCtx, IMapper mapper)
        {
            _clCtx = clCtx ?? throw new ArgumentNullException(nameof(clCtx));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Client> CreateClientAsync(UpdateClientRequest client)
        {
            var dbClient = _mapper.Map<ClientDb>(client);

            _clCtx.Clients.Add(dbClient);

            await _clCtx.SaveChangesAsync();

            return _mapper.Map<Client>(dbClient);
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            var countries = await _clCtx.Clients.Select(db => _mapper.Map<Client>(db)).ToListAsync();

            return countries;
        }

        public async Task<Client> GetClientByIdAsync(int clientId)
        {
            var dbClients = await _clCtx.Clients.Where(cntr => cntr.ClientId == clientId).ToArrayAsync();

            return _mapper.Map<Client>(dbClients[0]);
        }

        public async Task<int> RemoveClientByIdAsync(int clientId)
        {
            var entityToRemove = await _clCtx.Clients.Where(cntry => cntry.ClientId == clientId).ToArrayAsync();

            _clCtx.Clients.Remove(entityToRemove[0]);

            return await _clCtx.SaveChangesAsync();
        }

        public async Task<Client> UpdateClientByIdAsync(int clientId, UpdateClientRequest client)
        {
            var dbClients = await _clCtx.Clients.Where(c => c.ClientId == clientId).ToArrayAsync();

            if (dbClients[0] is null)
            {
                return null;
            }

            var newClient = _mapper.Map<ClientDb>(client);
            var oldClient = dbClients[0];

            newClient.ClientId = oldClient.ClientId;
            newClient.Created = oldClient.Created;
            newClient.Updated = DateTime.UtcNow;

            await _clCtx.SaveChangesAsync();

            return _mapper.Map<Client>(newClient);
        }
    }
}
