using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alma4 : MonoBehaviour
{
   
    public ENTE ente;



      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
             ente.TAlma4=true;
           
            gameObject.SetActive(false);
        }
    }
    
}