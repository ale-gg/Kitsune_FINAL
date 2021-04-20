using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENTE : MonoBehaviour
{

    public GameObject Alma1;
    public GameObject Alma2;
    public GameObject Alma3;   

    public GameObject Alma4;  
    public GameObject AlmaMadre;  
   
   public GameObject Texto1;
   public bool SpawnAlmas;
   public GameObject Almas;
   public bool PrimerTexto;

    public bool TAlma1;
    public bool TAlma2;
    public bool TAlma3;

    public bool TAlma4;
    
    public bool AllAlmas;





   void OnTriggerEnter2D(Collider2D obj){
       if(obj.tag=="Player" && PrimerTexto==false){
           Texto1.SetActive(true);
           SpawnAlmas=true;
            PrimerTexto=true;
           StartCoroutine ("TimerTexto1");
          
           }
           
       }
   

   


   IEnumerator TimerTexto1(){
        yield return new WaitForSeconds(3);
          Texto1.SetActive(false);
   }

    IEnumerator RespawnAlmas(){
        yield return new WaitForSeconds(2);
            Alma1.SetActive(true);
            Alma2.SetActive(true);
            Alma3.SetActive(true);
            Alma4.SetActive(true);
            TAlma1=false;
            TAlma2=false;
            TAlma3=false;
            TAlma4=false;
   }

    // Update is called once per frame
    void Update()
    {


        if(SpawnAlmas==true){
           Almas.SetActive(true);
        }

        if( TAlma1==false && TAlma2==true){
            Alma1.SetActive(false);
            Alma2.SetActive(false);
            Alma3.SetActive(false);
            Alma4.SetActive(false);
            StartCoroutine ("RespawnAlmas");
        }

          if( TAlma1==false && TAlma2==false && TAlma3==true){
            Alma1.SetActive(false);
            Alma2.SetActive(false);
            Alma3.SetActive(false);
            Alma4.SetActive(false);
            StartCoroutine ("RespawnAlmas");
        }

           if( TAlma1==true && TAlma2==false && TAlma3==true){
            Alma1.SetActive(false);
            Alma2.SetActive(false);
            Alma3.SetActive(false);
            Alma4.SetActive(false);
            StartCoroutine ("RespawnAlmas");
        }


           if( TAlma1==true && TAlma2==false && TAlma3==false&& TAlma4==true){
            Alma1.SetActive(false);
            Alma2.SetActive(false);
            Alma3.SetActive(false);
            Alma4.SetActive(false);
            StartCoroutine ("RespawnAlmas");
        }
          if( TAlma1==true && TAlma2==true && TAlma3==false&& TAlma4==true){
            Alma1.SetActive(false);
            Alma2.SetActive(false);
            Alma3.SetActive(false);
            Alma4.SetActive(false);
            StartCoroutine ("RespawnAlmas");
        }

          if( TAlma1==false && TAlma2==false && TAlma3==false&& TAlma4==true){
            Alma1.SetActive(false);
            Alma2.SetActive(false);
            Alma3.SetActive(false);
            Alma4.SetActive(false);
            StartCoroutine ("RespawnAlmas");
        }

        if(TAlma1==true&&TAlma2==true&&TAlma3==true&&TAlma4==true){
            AllAlmas=true;
        }
        if(AllAlmas==true){
            AlmaMadre.SetActive(true);
            TAlma1=false;
            TAlma2=false;
            TAlma3=false;
            TAlma4=false;
        }
        
    }

      



}
