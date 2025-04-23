using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_10 : MonoBehaviour
{
    public int Voto = 0; //voto da 1 a 10

    // Start is called before the first frame update
    void Start()
    {
        CalcolaVoto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CalcolaVoto()
    {
        if (Voto == 10)
        {
            Debug.Log("Il tuo voto è A+" );
        }
        else if (Voto == 9)
        {
            Debug.Log("Il tuo voto è A");
        }
        else if (Voto == 8 && Voto == 7)
        {
            Debug.Log("Il tuo voto è B");
        }
        else if (Voto == 6 )
        {
            Debug.Log("Il tuo voto è C");
        }
        else if (Voto == 5)
        {
            Debug.Log("Il tuo voto è E");
        }
        else
        {
            Debug.Log("Il tuo voto è F");
        }
    }
}
