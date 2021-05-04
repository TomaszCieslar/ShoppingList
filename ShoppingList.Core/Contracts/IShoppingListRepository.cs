using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Core
{
    public interface IShoppingListRepository
    {
        IEnumerable<Item> GetItems();

        Item GetItem(int id);

        void AddItem(Item newItem);

        void UpdateItem(int id, Item updatedItem);

        void DeleteItem(int id);
    }
}
