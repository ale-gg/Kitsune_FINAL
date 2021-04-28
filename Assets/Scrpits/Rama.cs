using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rama : MonoBehaviour
{
  public PlayerControler2D player;
    // Update is called once per frame
    void Update()
    {
        if(player.AllAlmas==true){
            Debug.Log("hola");
            gameObject.SetActive(true);
        }
    }
}
