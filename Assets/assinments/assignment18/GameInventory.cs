using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory Potion = new Inventory();
        Potion.AddItem("healing potion");
        Potion.AddItem("Strength potion");
        Inventory elixirs = new Inventory();
        elixirs.AddItem("elixir");
        elixirs.AddItem("dark elixir");
        Inventory combinedInventory = Potion + elixirs;
        combinedInventory.ShowItems();
    }
}
