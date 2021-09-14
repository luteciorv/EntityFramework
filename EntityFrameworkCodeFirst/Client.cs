using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public class Client
    {
        // Atributos
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int CPF { get; set; }
    }
}
