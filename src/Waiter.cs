using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    //Representa un mozo en el restaurante, encargado de atender mesas.

    public class Waiter
    {
        private List<Table> assignedTables = new List<Table>();

        //Es la responsabilidad de conocer el nombre del mesero.
        private string name;
        public string Name
        {
            get {return name; } set {name = value;}
        }

        //Método constructor.
        public Waiter(string name)
        {
            this.Name = name;
        }

        //El método sirve para agregar una mesa en la lista.
        public void AssignTable(Table table)
        {
            if (!assignedTables.Contains(table))
            {
                assignedTables.Add(table);
            } 
        }

        //El método sirve para tomar la orden de esa mesa.
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