using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    private void Start()
    {
        player1 player = new player1();
        Enemy enemy = new Enemy();
        player.SetUpCharacter("player ", 80);
        enemy.SetUpCharacter("enemy ", 20);
        player.Heal(10);
        enemy.Attack(10);
    }

}
