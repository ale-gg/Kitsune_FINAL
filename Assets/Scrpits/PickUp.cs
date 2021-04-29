using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
  void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
           GetComponent<AudioSource>().Play();
            StartCoroutine ("Esperar");
        }
  }    
        IEnumerator Esperar(){
        yield return new WaitForSeconds(1);
       Destroy(gameObject);
        }      
}
