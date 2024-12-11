using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1: Character
{
  
    public void Heal(int amount)
    {
        Health = Health+ amount;
        Debug.Log(Health + amount);
    }


}
