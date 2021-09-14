using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipBetweenObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            new CarModel() { Name = "Ford" }.Save();
        }
    }
}
