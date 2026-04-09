using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    // Use SRP y por lo tanto, creé una nueva clase para separar responsabilidades,
    // ya que la clase Table tenía más de una razón de cambio.
    // En este caso, esta clase se va a encargar de aquellos pedidos que se hagan por delivery.
    public class Delivery
    {
        private List<Dish> orden = new List<Dish>();

        //Este método sirve para agregar pedidos a una lista de pedidos.
        public void AddToOrder(Dish pedido)
        {
            orden.Add(pedido);
        }
        //Este método sirve para contar la cantidad de pedidos que se pidieron.
        public bool HasOrder()
        {
            return orden.Count > 0;
        }
       
        //Este método sirve para obtener el total de la compra por el delivery.
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