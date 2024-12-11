using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multipilication : MonoBehaviour
{

    int Multiply(int a , int b)
    {
        return a * b;
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int result = Multiply(5, i);
            Debug.Log($"{5}*{i} ={result}");
                        Debug.Log($"{5}*{i} ={result}");

            
        }
    }

}
