using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipBetweenObjects
{
    public class CarModel
    {
        // Atributos
        [Key()]
        public int CarModelId { get; set; }

        public string Name { get; set; }

        public List<Car> Cars { get; set; }

        public void Save()
        {
            var context = new BaseContext();
            context.CarModels.Add(this);
            context.SaveChanges();
        }

        /*
         * Retornar todos os elementos
         */
        public static List<CarModel> GetAll()
        {
            var context = new BaseContext();
            return context.CarModels.ToList();
        }
    }
}
