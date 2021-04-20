using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alma : MonoBehaviour
{
    public GameObject Alma1;
    public GameObject Alma2;
    public GameObject Alma3;

    public GameObject SAlma1;
    public GameObject SAlma2;
    public GameObject SAlma3;
    public bool AAlma1;
     public GameObject prefabAlma1;
     public GameObject prefabAlma2;
     public GameObject prefabAlma3;


    void Update()
    {
       if(Alma1 == null){
           AAlma1=true; //!!!!!!!!!!!!!
       }

        if(Alma2 == null){
            if(AAlma1 == false){
                Destroy(Alma1);
                Destroy(Alma2);
                Destroy(Alma3);

                StartCoroutine ("Reset");

            }
        }

    } 

    IEnumerator Reset(){
        yield return new WaitForSeconds(2);
        Debug.Log ("OLA ola");
        Instantiate(prefabAlma1,SAlma1.transform.position,SAlma1.transform.rotation);
        Instantiate(prefabAlma2,SAlma2.transform.position,SAlma1.transform.rotation);
        Instantiate(prefabAlma3,SAlma3.transform.position,SAlma1.transform.rotation);
        }




     void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="player"){
            
            Destroy(gameObject);
        }
    }
  
}



