using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_7 : MonoBehaviour
{
    public int a = 35;
    public int b = 17;
    // Start is called before the first frame update
    void Start()
    {
        MaggioreTra2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MaggioreTra2()
    {
        if (a > b)
        {
            Debug.Log(a);

        }
        else
        {
            Debug.Log(b);
        }
    }
}
