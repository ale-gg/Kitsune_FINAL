using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmaMadre : MonoBehaviour
{
  public PlayerControler2D player;

  

      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
            Debug.Log("hola");
        gameObject.SetActive(false);
        }
    }
    
}
