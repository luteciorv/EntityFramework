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
            //new CarModel() { Name = "Ford" }.Save();
            while (true)
            {
                Console.Write("1 - Finalizar \n2 - Continuar \nDigite aqui: ");
                int answer = int.Parse(Console.ReadLine());

                if(answer == 1) { break; }
            }
        }
    }
}
