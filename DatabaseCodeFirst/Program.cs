using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pegar todos os clientes
            var clients = new VendasWebContext().Clients.ToList();
            Client client = clients[0];

            // Pegar todos os produtos
            var products = new VendasWebContext().Products.ToList();
            Product product = products[0];

            // Pegar todos os pedidos
            var requests = new VendasWebContext().Requests.ToList();
            Request request = requests[0];

            // Pegar todos os pedidos-produtos
            var requestsProducts = new VendasWebContext().RequestsProducts.ToList();
            RequestProduct requestProduct = requestsProducts[0];
        
        }
    }
}
