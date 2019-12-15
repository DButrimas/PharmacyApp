using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp
{
    class ClientSql
    {
        static PharmacyDBEntities _context = new PharmacyDBEntities();

        public static async Task<List<Client>> GetClientList()
        {
            return await _context.Clients.ToListAsync();
            
        }
        public static async void UpdateClientsPostCodes(Client client)
        {
            var result = await _context.Clients.SingleOrDefaultAsync(x => x.id == client.id);
            if (result != null)
            {
                _context.Clients.SingleOrDefault(x => x.id == client.id).post_code = client.post_code;
            }
        }
        public static void InsertClients(List<Client> clients)
        {
            foreach (var client in clients)
            {
                if (!_context.Clients.Any(x => x.name == client.name && x.address == client.address))
                {
                    _context.Clients.Add(client);
                }
            }
        }
        public static async void SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}