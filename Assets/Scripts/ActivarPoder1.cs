using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPoder1 : MonoBehaviour
{

    public PlayerControler2D kitsune;

 

     void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
           
          
           kitsune.poder1=true;
           gameObject.SetActive(false);
            

        }
     }  


     
     
}
