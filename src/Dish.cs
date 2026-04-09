using System.Reflection.Metadata;

namespace Ucu.Poo.Restaurant
{


    // Representa un platillo individual en el menú del restaurante.
    public class Dish
    {
        //Coloco aquellas responsabilidades que se tienen que conocer en la clase Dish.
        public string Name { get; set; }
        public double Price { get;set; }
        public bool IsVegetarian { get;set; }

        //método constructor.
        public Dish(string Name, double Price, bool IsVegetarian)
        {
            this.Name = Name;
            this.Price = Price;
            this.IsVegetarian = IsVegetarian;
        }
    }
}
