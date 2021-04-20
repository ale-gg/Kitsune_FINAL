using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONTROL : MonoBehaviour
{
       
    public float velocidadAndar;

    public float velocidadDash;
    
    float velocidadActual;

    public float fuerzaSalto;

    public int limiteSaltos;

    int saltosActuales = 0;
    
    public float Gravedad;

    public bool Poder2;

    public bool Poder3;

    public GameObject fantasma;

    public int fuerzaViento;




    

    
    
    
  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(velocidadActual * Time.deltaTime,0, 0);
            velocidadActual=0f;
         if(Input.GetKey(KeyCode.RightArrow)){
              velocidadActual=0;

            transform.eulerAngles=new Vector3(0,0,0);
         
            velocidadActual=velocidadAndar;

        }else{
            if (!Input.GetKey(KeyCode.LeftArrow)){

                velocidadActual=0;
            

               
            }
            else
            {
               
                transform.eulerAngles = new Vector3(0, 180, 0);
                
                velocidadActual = velocidadAndar;


            }
        }


         if(Input.GetKeyDown(KeyCode.Space)&& Poder3==false){
             GetComponent<Rigidbody2D>().gravityScale = 0;
            if (saltosActuales<limiteSaltos){
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0,fuerzaSalto),ForceMode2D.Impulse); // Aplica un impulso vertical ( por eso x=0) a el objeto con el script Getcomponent
                saltosActuales++;
            }

          StartCoroutine ("Esperar2");

        }


         if(Input.GetKeyDown(KeyCode.Space)&& Poder3==true){
             GetComponent<Rigidbody2D>().gravityScale = 0;
             GetComponent<Rigidbody2D>().AddForce(new Vector2(0,fuerzaSalto),ForceMode2D.Impulse); // Aplica un impulso vertical ( por eso x=0) a el objeto con el script Getcomponent
             }


        if(Input.GetKeyUp(KeyCode.Space)){
             StartCoroutine ("Esperar");
        }

         if(Input.GetKeyDown(KeyCode.LeftShift)){
              velocidadActual=0;
                velocidadActual=velocidadDash;
                StartCoroutine ("EsperarDash");

         }
            
      
       transform.Translate(velocidadActual*Time.deltaTime,0,0);

    }


       void OnCollisionEnter2D(Collision2D col) {
        Debug.Log("Chocando con algo");
        if(col.collider.tag=="suelo" && transform.position.y>col.collider.transform.position.y){
            saltosActuales=0;
        }
       
    

        



    }

    void OnTriggerStay2D(Collider2D other){
           if(other.tag=="Poder2"){
                 if(Input.GetKeyDown(KeyCode.E)){
                     if(Poder2==true){
                        Destroy(fantasma);
                     }    
                 }
           }
        }


    IEnumerator Esperar(){
        yield return new WaitForSeconds(0);
        GetComponent<Rigidbody2D>().gravityScale = Gravedad;
    

    }


      IEnumerator Esperar2(){
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody2D>().gravityScale = Gravedad;
    

    }


     IEnumerator EsperarDash(){
        yield return new WaitForSeconds(1);
        velocidadActual=velocidadAndar;
    

    }
        
}








