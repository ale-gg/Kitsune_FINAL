using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmaMadre : MonoBehaviour
{
  public ENTE ente;
  public GameObject SALIDA;
  public int SumAlma;
 
      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
           
             SumAlma=(SumAlma+1);
              gameObject.SetActive(false);
            ente.AllAlmas=false;
            ente.TAlma1=false;
            ente.TAlma2=false;
            ente.TAlma3=false;
            gameObject.SetActive(false);
            SALIDA.SetActive(true);
        }
    } 
    
}
