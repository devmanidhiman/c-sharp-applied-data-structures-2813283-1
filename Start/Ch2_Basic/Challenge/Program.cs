// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge: Chapter 2

using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Test Code
            ShoppingList list = new();
            list.AddItem("Milk", 2.25, 1);
            list.AddItem("Sugar", 1.75, 2);
            list.AddItem("Bread", 3.25, 1);
            list.AddItem("Butter", 4.95, 1);
            Console.WriteLine($"Items: {list.GetCount()}");

            list.PrintList();

            list.RemoveItem("Bread");
            list.RemoveItem("Sugar");
            list.AddItem("Cookies", 0.50, 4);
            list.AddItem("Oranges", 0.65, 5);
            list.AddItem("Chicken", 8.95, 1);
            Console.WriteLine($"Items: {list.GetCount()}");

            list.PrintList();
        }
    }
    public class ShoppingItem
    {
        public string itemName;
        public double price;
        public int quantity;
    }
    public class ShoppingList
    {
        List<ShoppingItem> items = new List<ShoppingItem>();

        public void AddItem(string ItemName, double Price, int Quantity)
        {
            items.Add(new ShoppingItem() {itemName = ItemName, price = Price, quantity = Quantity});
        }

        public void RemoveItem(string ItemName)
        {
            ShoppingItem itemFound = null;
            foreach (var item in items)
            {
                itemFound = item;
                break;
            }
            if (itemFound != null)
            {
                if (itemFound.quantity > 1){
                    itemFound.quantity -= 1;
                }
                else items.Remove(itemFound);
                
            }
        
        }

        public int GetCount()
        {
            int count = 0;
            foreach (var item in items)
            {
                count += item.quantity;
            }
            return count;
        }

        public void PrintList()
        {
            foreach (var item in items)
            {
                 Console.WriteLine($"Item: {item.itemName,10}, Price: {item.price:C}, Quantity: {item.quantity}");
             }
        }
    }
}
