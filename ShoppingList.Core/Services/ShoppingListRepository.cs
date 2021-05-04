using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingList.Core
{
    public class ShoppingListRepository : IShoppingListRepository
    {
        List<Item> ShoppingList = new List<Item>();
        
        public void AddItem(Item newItem)
        {
            ShoppingList.Add(newItem);
        }

        public void DeleteItem(int id)
        {
            Item item = ShoppingList.FirstOrDefault(item => item.id == id);
            if (item != null)
            {
                ShoppingList.Remove(item);
            }
        }

        public Item GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            ShoppingList.ToList().ForEach(s => Console.WriteLine(s.Name));
            return ShoppingList;
        }

        public void UpdateItem(int id, Item updatedItem)
        {

            Item item = ShoppingList.FirstOrDefault(element => element.id == id);
            if (item != null)
            {
                item = updatedItem;
            }
        }
    }
}
