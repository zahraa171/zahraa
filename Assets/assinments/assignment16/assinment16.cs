using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment8
{
    public struct Position
    {
        public float X, Y, Z;
        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public void PrintPosition()
        {
            Debug.Log($"position:X = {X}, Y = {Y}, Z = {Z}");
        }
    }
    public class Character
    {
        public string name { get; set; }
        private int health;
        protected Position position;
        public int Health
        {
            get { return health; }
        set { if (value > 100) health = 100; }
        }
        public Character(string Name, int health, Position position)
        {
            name = Name;
            Health = health;
            this.position = position;
        }
        public Character() : this("No name", 100, new Position(0, 0, 0)) { }
        public virtual void DisplayInfo()
        {
            Debug.Log($"name: {name},health: {Health}");
            position.PrintPosition();
        }
        public void Attack(int damage, Character target)
        {
            target.Health -= damage;
            Debug.Log($"{name} attacked {target.name} for {damage} damage.");
        }
        public void Attack(int damage, Character target, string attackType)
        {
            Debug.Log($"attack type: {attackType}");
            Attack(damage, target);
        }
    }
    public class Soldier : Character
    {
        public Soldier(string name, int health, Position position) : base(name, health, position) { }
        public Soldier() : base() { }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name, health, position) { }
        public override void DisplayInfo()
        {
            Debug.Log("officer");
            base.DisplayInfo();
        }
    }
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Character[] characters = new Character[2];
            characters[0] = new Soldier();
            characters[1] = new Officer("Commander", 90, new Position(10, 15, 20));
            foreach (var character in characters)
            {
                character.DisplayInfo();
            }
            Officer officer = (Officer)characters[1];
            Soldier soldier = (Soldier)characters[0];
            Debug.Log($"soldier health before attack: {soldier.Health}");
            officer.Attack(20, soldier, "shooting");
            Debug.Log($"Soldier health after attack: {soldier.Health}");
        }
    }
}
