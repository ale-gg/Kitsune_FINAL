using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poder1 : MonoBehaviour
{
  public PlayerControler2D player;

  

      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
             player.poder1=true;
           
            gameObject.SetActive(false);
        }
    }
    
}

