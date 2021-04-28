using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MANIN : MonoBehaviour
{
  public PlayerControler2D player;
  public GameObject AlmasPack;

  

      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
            AlmasPack.SetActive(true);
            if(player.AllAlmas==true){
                Debug.Log("hola");
            }

        }
    }
    
}
