using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    //Agregue esta nueva clase porque tuve que aplicar el principio de responsabilidad única.
    //La justificación de porque aplique SRP fue porque habia más de una razón de cambio.
    public class Delivery
    {
        private List<Dish> orden = new List<Dish>();
        public void AddToOrder(Dish pedido)
        {
            orden.Add(pedido);
        }
        public bool HasOrder()
        {
            return orden.Count > 0;
        }
       
        public double GetTotal()
        {
                double result = 0;
                foreach (Dish item in this.orden)
                {
                    result = result + item.Price;
                }
                return result;
 
        }
    }
}