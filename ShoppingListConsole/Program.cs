using ShoppingList.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingListConsole
{
    class Program
    {
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

            ShoppingListRepository repository = new ShoppingListRepository();
            
            while (option!=5)
            {
                Console.Write("Choose option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Item newItem = new Item { 
                        Name = "Pomidor"
                        };
                        repository.AddItem(newItem);
                        break;
                    case 2:
                        repository.DeleteItem(0);
                        break;
                    case 3:
                        Item updateItem = new Item();
                        repository.UpdateItem(0,updateItem);
                        break;
                    case 4:
                        repository.GetItems();
                        break;
                    default:
                        break;
                }
            }
        }

       
     
    }
}
