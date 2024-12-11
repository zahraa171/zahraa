using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player 
{
    public string playerName;
    public int health;
    public static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
        Debug.Log($"the player name is {name}and the health is {health}");

    }
    public void Heal(int amount)
    {
        health += amount;
        Debug.Log($"the {playerName} health = {health} ");
    }
    public void Heal(bool fullRestore)
    {
      health = 100;
        Debug.Log($"the {playerName} health = {health} ...fullRestore");
    }
    public static void ShowPlayerCount()
    {
        Debug.Log($"the player count = {playerCount}" );
    }


}
