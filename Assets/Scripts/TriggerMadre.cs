using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMadre : MonoBehaviour
{
public GameObject texto;
      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
             texto.SetActive(true);
           
          StartCoroutine ("TimerTexto1");
          
           }
           
       }
   

   


   IEnumerator TimerTexto1(){
        yield return new WaitForSeconds(4);
          texto.SetActive(false);
   }

}   