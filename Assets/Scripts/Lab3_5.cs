using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_5 : MonoBehaviour
{
    public int Partenza = 22;
    
    // Start is called before the first frame update
    void Start()
    {
        Stampa2successivi();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Stampa2successivi() {
        int succ1 = Partenza + 1;
        int succ2 = succ1 + 1;

        Debug.Log("il valore iniziale è di " + Partenza + " i due valori successivi sono: " + succ1+ " "+succ2);
    
    }
}
