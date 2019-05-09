using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OlympicFlights.Service.ClientManagement
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetClientsAsync();

        Task<Client> GetClientByIdAsync(int clientId);

        Task<Client> CreateClientAsync(UpdateClientRequest client);

        Task<int> RemoveClientByIdAsync(int clientId);

        Task<Client> UpdateClientByIdAsync(int clientId, UpdateClientRequest client);
    }
}
