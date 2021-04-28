using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
public float velocidadAndar;
public float velocidadEscalar;
    
float velocidadActual;

public float Gravity;

public GameObject prefabFantasma;
public GameObject spawnF;
public bool posesion;
public bool pose;
  
    

    
    
    
  


    // Start is called before the first frame update
    void Start()
    {
    velocidadActual=0;
    }

    // Update is called once per frame
    void Update()
    {
      
      if(Input.GetKeyDown(KeyCode.F)&& posesion ==true){
        transform.eulerAngles=new Vector3(0,0,0);
        posesion = false;
        pose = true;
         
      }
       if(Input.GetKeyUp(KeyCode.F)){
        
        pose = false;
       
      }

      if(posesion ==true){
            transform.Translate(velocidadActual * Time.deltaTime,0, 0);
            velocidadActual=0f;
         if(Input.GetKey(KeyCode.D)&& posesion ==true){
              velocidadActual=0;

            transform.eulerAngles=new Vector3(0,0,0);
         
            velocidadActual=velocidadAndar;

        }else{
            if (!Input.GetKey(KeyCode.A)&& posesion ==true){

                velocidadActual=0;
            

               
            }
            else
            {
               
                transform.eulerAngles = new Vector3(0, 180, 0);
                
                velocidadActual = velocidadAndar;


            }
        }



        
      
         
      

       transform.Translate(velocidadActual*Time.deltaTime,0,0);
      }
      if(Input.GetKeyDown(KeyCode.F)&& pose ==true){ // si pulso F una vez
            Instantiate(prefabFantasma,spawnF.transform.position,spawnF.transform.rotation);
         } 
        
    }

        

    
        





        void OnTriggerStay2D(Collider2D other){
            if(other.tag=="Arbol"){
              Debug.Log("hola");
               GetComponent<Rigidbody2D>().gravityScale = 0;
             if(Input.GetKey(KeyCode.W)){
            velocidadActual=0;
       
              transform.eulerAngles = new Vector3(0,0, 90);
                
                velocidadActual = velocidadEscalar;

                }
                  if(Input.GetKey(KeyCode.DownArrow)){
            velocidadActual=0;
       
              transform.eulerAngles = new Vector3(0,0, -90);
                
                velocidadActual = velocidadAndar;

                }
           
           
            }
            if(other.tag=="Player" && Input.GetKeyDown(KeyCode.E)){
            posesion=true;
          }  
        }

        
         void OnTriggerExit2D(Collider2D other){
            if(other.tag=="Arbol"){
               GetComponent<Rigidbody2D>().gravityScale = Gravity;
            }
        }

}









