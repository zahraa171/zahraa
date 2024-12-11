using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Character[] characters = new Character[3];
            characters[0] = new Soldier();
            characters[1] = new Officer("Officer", 90, new Position(10, 15, 20));
            characters[2] = new Soldier("soldier", 100, new Position(10, 15, 20));

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }

            Soldier soldier = (Soldier)characters[0];
            Soldier soldier1 = (Soldier)characters[2];
            Officer officer = (Officer)characters[1];

            Debug.Log($" health before the attack: {soldier.Health}");
            officer.Attack(20, soldier, "hit");
            Debug.Log($" health after the attack: {soldier.Health}");

            Debug.Log($" health before the attack: {soldier1.Health}");
            officer.Attack(20, soldier1, "shoot");
            Debug.Log($" health after the attack: {soldier1.Health}");
        }
    }

}
