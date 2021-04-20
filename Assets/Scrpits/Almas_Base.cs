using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Almas_Base : MonoBehaviour
{
    public ENTE ente;



      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="player"){
             
             ente.TAlma1=true;
           
            gameObject.SetActive(false);
        }
    }
    
}



