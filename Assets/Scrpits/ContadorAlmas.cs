using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorAlmas : MonoBehaviour
{
   public int AlmasTotales;
   public AlmaMadre almaMadre;

    // Update is called once per frame
    void Update()
    {
        AlmasTotales=almaMadre.SumAlma;

        
        
    }
}
