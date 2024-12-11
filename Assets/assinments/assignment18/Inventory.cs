using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment18
{
    public class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
        }
        public void ShowItems()
        {
            foreach (var item in items)
            {
                Debug.Log(item);
            }
        }
        public static Inventory operator +(Inventory a, Inventory b)
        {
            Inventory combinedInventory = new Inventory();
            combinedInventory.items.AddRange(a.items);
            combinedInventory.items.AddRange(b.items);
            return combinedInventory;
        }
    }
}
