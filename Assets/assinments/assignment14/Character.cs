using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    private string name;
    private int health;
    public string Name 
    {
        get { return name; }
        set { name = value; }
    }
    public int Health
    {
        get { return health; }
        set { if (value > 100) health = 100; }
    }
    public void SetUpCharacter(string name, int health)
    {
        this.name = name;
        this.health = health;
        Debug.Log($"the name is: {name} and health: {health}");
    }
    
}
