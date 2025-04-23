using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_6 : MonoBehaviour
{
    public int Partenza = 22;

    // Start is called before the first frame update
    void Start()
    {
        //Stampa2successivi();
        Stampa2precedenti();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Stampa2successivi()
    {
        int succ1 = Partenza + 1;
        int succ2 = succ1 + 1;

        Debug.Log("il valore iniziale è di " + Partenza + " i due valori successivi sono: " + succ1 + " " + succ2);

    }

    void Stampa2precedenti()
    {
        int pre1 = Partenza - 1;
        int pre2 = pre1 - 1;

        Debug.Log("il valore iniziale è di " + Partenza + " i due valori precedenti sono: " + pre1 + " " + pre2);

    }
}
