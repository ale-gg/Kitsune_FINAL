using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTutorial : MonoBehaviour
{
   public GameObject texto;
      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
             texto.SetActive(false);
           
          
          
           }
           
       }
}       
   

   

