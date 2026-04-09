using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Table
    {
        private List<Dish> order = new List<Dish>();

        //Es la responsabilidad de conocer el número de la mesa.
        private int number;
        public int Number
        {
            get {return number; } set {number = value;}
        }

        //Es la responsabilidad de conocer si la mesa está ocupada o no.
        private bool isOccupied;
        public bool IsOccupied
        {
            get {return isOccupied; } set {isOccupied = value;}
        }

        //método constructor.
        public Table(int number)
        {
            this.Number = number;
            this.IsOccupied = false;
        }

        //se obtiene si la mesa está ocupada o no.
        public void Occupy()
        {
            if (IsOccupied)
            {
                Console.WriteLine("La mesa esta ocupada");
            }
            else
            {
                IsOccupied = true;
                Console.WriteLine("La mesa ahora esta ocupada");
            }
        }
        //se obtiene si la mesa está libre.
        public void Free()
        {
            if (IsOccupied)
            {
                IsOccupied = false;
                order.Clear();
                Console.WriteLine("La mesa ha sido liberada");
            }
            else
            {
                Console.WriteLine("La mesa ya esta libre");
            }
        }
        //Con este método se agrega un pedido a la lista de pedidos.
        public void AddToOrder(Dish pedido)
        {
            order.Add(pedido);
        }
        //Con este método se cuenta la cantidad de pedidos que hay en la lista de pedidos.
        public bool HasOrders()
        {
            return order.Count > 0;
        }

        //Este método se implementa en esta clase porque es la que
        //contiene la información necesaria para realizar la responsabilidad.
        public double GetTotal()
        {
                double result = 0;
                foreach (Dish item in this.order)
                {
                    result = result + item.Price;
                }
                return result;
 
        }
    }
}