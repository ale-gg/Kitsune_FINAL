using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTexto : MonoBehaviour
{
    public GameObject texto;
      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
             texto.SetActive(true);
           
          StartCoroutine ("TimerTexto1");
          
           }
           
       }
   

   


   IEnumerator TimerTexto1(){
        yield return new WaitForSeconds(3);
          texto.SetActive(false);
   }

}   