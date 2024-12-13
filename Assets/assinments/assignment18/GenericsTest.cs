using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> test =new GameContainer<string>();
        test.SetItem("Healing Potition");
        Debug.Log($"stored item :{test.GetItem()}");
        Debug.Log(GameUtils.DescribeItem(test.GetItem()));


    }

 
}
