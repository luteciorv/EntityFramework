using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ClientContext())
            {
                // Adicionar um cliente
                var amountClients = context.Clients.Count();
                context.Clients.Add(new Client() { Name = "Luís Felipe", Phone = 998458121, CPF = 1472583969 });

                // Adicionar um produto
                context.Products.Add(new Product() { Name = "Relógio", Description = "Comumente utilizado para se informar acerca das horas"});

                // Salvar as alterações
                context.SaveChanges();
            }
        }
    }
}
