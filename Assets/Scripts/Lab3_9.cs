using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float TempoTrascorso = Time.time;


        if (TempoTrascorso > 60f)
        {
            Debug.Log("è trascorso più di 1 minuto ");
        }


        else if (TempoTrascorso >= 45f)
        {
            Debug.Log("sono trascorsi più di 45 secondi");
        }

        else if (TempoTrascorso >= 30f)
        {
            Debug.Log("sono trascorsi più di 30 secondi");
        }

        else
        {
            Debug.Log("sono trascorsi meno di 30 secondi");
        }
     }

 }

    

