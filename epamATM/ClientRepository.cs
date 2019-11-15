using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamATM
{
    public class ClientRepository
    {
        private List<Client> _clients;
        public ClientRepository()
        {
            Initialize();
        }
        private void Initialize()
        {
            _clients = new List<Client>
            {
                new Client("ooga", "booga", "1234", 10)
            };
        }
        public Client GetClientByPin(string pin)
        {
            return _clients.FirstOrDefault(x => x.PinCode == pin);
        }

    }
}
