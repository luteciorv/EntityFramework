using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipBetweenObjects
{
    public class BaseContext : DbContext
    {
        // Método construtor
        public BaseContext() : base("Relationsip") { }

        // Tabelas
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
