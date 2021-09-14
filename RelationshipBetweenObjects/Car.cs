using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipBetweenObjects
{
    public class Car
    {
        // Atributos
        public int CarId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        [ForeignKey("CarModel")]
        public int CarModelId { get; set; } // Chave estrangeira
        public virtual CarModel CarModel { get; set; }

        public void Save()
        {
            var context = new BaseContext();
            context.Cars.Add(this);
            context.SaveChanges();
        }

        /*
         * Retornar todos os elementos
         */
        public static List<Car> GetAll()
        {
            var context = new BaseContext();
            return context.Cars.ToList();
        }
    }
}
