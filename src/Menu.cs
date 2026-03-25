using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Ucu.Poo.Restaurant
{
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }
        public  Dish GetDishByName(string name)
        {
            return dishes.FirstOrDefault(plato => plato.Name == name);
        } 
    }
}