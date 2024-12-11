using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    
    public struct position 
    {
        public float x,y,z;
        public position(float x ,float y,float z)
        {
            this.x=x;
            this.y=y;
            this.z=z;
        }
        public void PrintPosition()
        {
            Debug.Log($" x: {x} ,  y: {y} , z: {z}");
        }
    }
}

