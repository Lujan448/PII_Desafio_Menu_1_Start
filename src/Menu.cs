using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Ucu.Poo.Restaurant
{
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        //Agrego un método para poder agregar los platos a la lista de platos.

        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        //Agregue un método para poder remover aquellos platos que esten en la lista de platos.
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        //Agregue un método para poder el plato por su nombre.
        public  Dish GetDishByName(string name)
        {
            return dishes.FirstOrDefault(plato => plato.Name == name);
        } 
    }
}