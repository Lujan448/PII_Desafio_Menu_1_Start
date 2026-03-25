using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Table
    {
        private List<Dish> order = new List<Dish>();

        private int number;
        public int Number
        {
            get {return number; } set {number = value;}
        }

        private bool isOccupied;
        public bool IsOccupied
        {
            get {return isOccupied; } set {isOccupied = value;}
        }

        public Table(int number)
        {
            this.Number = number;
            this.IsOccupied = false;
        }

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

        public void AddToOrder(Dish pedido)
        {
            order.Add(pedido);
        }
        public bool HasOrders()
        {
            return order.Count > 0;
        }
    }
}