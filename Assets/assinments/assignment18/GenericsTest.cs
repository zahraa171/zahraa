using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> potionContainer = new GameContainer<string>();
            potionContainer.Item = "healing potion"; 
            string storedItem = potionContainer.Item;
            Debug.Log($"stored item: {storedItem}");
            string description = GameUtils.DescribeItem(storedItem);
            Debug.Log(description);
        }
    }
}

