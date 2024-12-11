using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Assignment18
{
        public class GameContainer<T>
        {
            public T Item { get; set; }
        }
        public static class GameUtils
        {
            public static string DescribeItem<T>(T something)
            {
                return $"This item is {something}.";
            }
        }
 }
