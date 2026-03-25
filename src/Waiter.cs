using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private List<Table> assignedTables = new List<Table>();

        private string name;
        public string Name
        {
            get {return name; } set {name = value;}
        }

        public Waiter(string name)
        {
            this.Name = name;
        }

        public void AssignTable(Table table)
        {
            if (!assignedTables.Contains(table))
            {
                assignedTables.Add(table);
            } 
        }

        public void TakeOrder(Table table, Dish dish)
        {
            if (!assignedTables.Contains(table))
            {
                Console.WriteLine($"{Name} no tiene asingada la mesa {table.Number}");
            }
            if (!table.IsOccupied)
            {
                Console.WriteLine($"La mesa {table.Number} no esta ocupada");
            }
            table.AddToOrder(dish);
            Console.WriteLine($"Pedido de {dish.Name} agregado a la mesa {table.Number}");

        }
    }
}