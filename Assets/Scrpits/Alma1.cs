using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alma1 : MonoBehaviour
{
  public ENTE ente;



      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
             ente.TAlma1=true;
           
            gameObject.SetActive(false);
        }
    }
    
}

