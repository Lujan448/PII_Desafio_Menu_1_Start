using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Delivery
    {
        private List<Dish> orden = new List<Dish>();
        public void AddToOrden(Dish pedido)
        {
            orden.Add(pedido);
        }
        public bool HasOrdenes()
        {
            return orden.Count > 0;
        }
       
        public double GetTotalDelivery()
        {
                double resultado = 0;
                foreach (Dish item in this.orden)
                {
                    resultado = resultado + item.Price;
                }
                return resultado;
 
        }
    }
}