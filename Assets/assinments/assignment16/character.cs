using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Character
    {
        public string name;
        protected Position position;
        private int health;
        public int Health
        {
            get { return health; }
            set
            {
                // if (value > 100) { value = 100; }
                //else if (value < 0) { value = 0; }
                //else { health = value; }
                health = Mathf.Clamp(value, 0, 100);
                ;
            }
        }

        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0))
        {

        }

        public virtual void DisplayInfo()
        {
            Debug.Log($"the character name is {name} and the health is {health}");
            position.PrintPosition();
        }

        public void Attack(int damage, Character target)
        {
            target.health -= damage;
            Debug.Log($"{name} attacked {target.name} for {damage} damage the health is {health}");
        }
        public void Attack(int damage, Character target, string attackType)
        {
            Attack(damage, target);
            Debug.Log($"attack type: {attackType}");
        }
    }

    public class Soldier : Character
    {
        public Soldier(string name, int health, Position position) : base(name, health, position) { }
        public Soldier() : base() { }
        public override void DisplayInfo()
        {
            Debug.Log("soldier");
            base.DisplayInfo();
        }

    }
    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name, health, position) { }

        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }

}
