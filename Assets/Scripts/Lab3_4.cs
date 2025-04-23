using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_4 : MonoBehaviour
{
    public int numero = 13;


    // Start is called before the first frame update
    void Start()
    {
        int pari_dispari = numero % 2;


        if (pari_dispari == 0)
        {
            Debug.Log("Il numero " + numero + " è pari");

        }
        else
        {
            Debug.Log("Il numero " + numero + " è dispari");
        }

        if (numero > 10)
        {
            Debug.Log("Il numero " + numero + " è maggiore di 10");

        }
        else
        {
            Debug.Log("Il numero " + numero + " è Minore di 10");
        }


    }
}
