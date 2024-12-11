using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        player player1 = new player();
        player player2 = new player();
        player1.InitializePlayer("player1", 100);
        player2.InitializePlayer("player2", 50);
        player2.Heal(20);
        player2.Heal(true);
        Debug.Log("player number ="+ player.playerCount);


    }
}
