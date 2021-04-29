using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
public bool Cambio;

   void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
            Debug.Log("hola");
            Cambio=true;
        }
    }
   
}
