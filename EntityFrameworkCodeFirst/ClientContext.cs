using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public class ClientContext : DbContext
    {
        // Tabelas
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
