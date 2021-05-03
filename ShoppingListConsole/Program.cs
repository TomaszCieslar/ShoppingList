using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingListConsole
{
    class Program
    {
        static List<Item> ShoppingList = new List<Item>();
        static void Main(string[] args)
        {
            int option = 0;
            Console.WriteLine("ShoppingList List v 0.1");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Update Item");
            Console.WriteLine("4. Show All");
            Console.WriteLine("5. exit");

            while (option!=5)
            {
                Console.Write("Choose option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        RemoveItem();
                        break;
                    case 3:
                        UpdateItem();
                        break;
                    case 4:
                        ShowAllElements();
                        break;
                    default:
                        break;
                }
            }
        }

        static void AddItem()
        {
            Console.WriteLine("---Add Item---");
            Item item = new Item();

            ShoppingList.Add(item);
        }

        static void UpdateItem()
        {
            Console.WriteLine("---Update Item---");
            Item item = new Item();
            int id = 0;

            Item element = ShoppingList.FirstOrDefault(element => element.id == id);
            if (element != null)
            {
                element = item;
            }
        }

        static void RemoveItem()
        {
            Console.WriteLine("---Remove Item---");
            int id = 0;
            Item element = ShoppingList.FirstOrDefault(element => element.id == id);
            if (element != null)
            {
                ShoppingList.Remove(element);
            }
        }

        static void ShowAllElements()
        {
            Console.WriteLine("---Show All---");
            foreach (var item in ShoppingList)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
