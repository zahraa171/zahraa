using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
            Inventory potionInventory = new Inventory();
            potionInventory.AddItem("healing potion");
            potionInventory.AddItem("Strength potion");
            Inventory elixirInventory = new Inventory();
            elixirInventory.AddItem("elixir");
            elixirInventory.AddItem("dark elixir");
            Inventory combinedInventory = potionInventory + elixirInventory;
            combinedInventory.ShowItems();
        }
    }
}
