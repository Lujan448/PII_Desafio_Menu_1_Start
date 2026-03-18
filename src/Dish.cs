using System.Reflection.Metadata;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        public string Name { get; set; }
        public double Price { get;set; }
        public bool IsVegetarian { get;set; }

        //Constructor
        public Dish(string Name, double Price, bool IsVegetarian)
        {
            this.Name = Name;
            this.Price = Price;
            this.IsVegetarian = IsVegetarian;
        }
    }
}
