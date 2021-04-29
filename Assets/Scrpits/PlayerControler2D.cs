using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler2D : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed= 60f;
     public float Speed;

    float horizontalMove= 0f;

    bool jump = false;

     public float Gravedad;

     private Animator anim;

      public bool CooldawnDash;

       public float tiempo;

       public bool poder1;

       public bool poder2;

       public bool AllAlmas;

    public GameObject murito;
    public GameObject murito1;
    public GameObject murito2;
    public GameObject murito3;

    public bool TAlma1;
    public bool TAlma2;
    public bool TAlma3;
    public bool TAlma4;

    public GameObject AlmaMadre;

    public GameObject Rama;

    

    
    


      



    
    // Update is called once per frame

    private  void Start()
    {
        {
            anim=GetComponent<Animator>();
          
        }
    }
    void Update()
    {

        if(AllAlmas==true){
           
            Rama.SetActive(true);
            AlmaMadre.SetActive(true);
            AllAlmas=false;
        }
    
            
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

       

        
      
       if(Input.GetButton("Horizontal"))
        {
           
             anim.SetBool("Walk", true);
           
        }else{
            anim.SetBool("Walk", false);
        }

        if(Input.GetButtonDown("Jump"))
        {
            jump=true;
            
             GetComponent<Rigidbody2D>().gravityScale = 0;
             StartCoroutine ("Esperar2");
        }

             if(Input.GetButtonUp("Jump")){
             StartCoroutine ("Esperar");
        }


       void OnCollisionEnter2D(Collision2D col) {
       
        if(col.collider.tag=="suelo"){
            
                Debug.Log("tocando");
                anim.SetBool("Jump", false);
            }
        }

          if(Input.GetKey(KeyCode.LeftShift)&& poder1==true && CooldawnDash==false){
                anim.SetBool("Dash", true);
                runSpeed= Speed;
                CooldawnDash=true;
                StartCoroutine ("EsperarDash");
                StartCoroutine ("CDRDash");
                 

         }else{
              anim.SetBool("Dash", false);
         }

         if(TAlma1==true && TAlma2==true && TAlma3==true && TAlma4==true){
             AllAlmas=true;
         }
         
         

    }
             void OnTriggerStay2D(Collider2D other){
           if(other.tag=="poder2"){
                 if(Input.GetKeyDown(KeyCode.E)){
                     if(poder2==true){
                        Destroy(gameObject);
                     }    
                 }
           }
        }

            void OnCollisionStay2D(Collision2D col) {
              
                if(poder1==true && runSpeed==400){
                    Debug.Log("Chocando con algo");
               
                murito.GetComponent<BoxCollider2D>().isTrigger= true;
                murito1.GetComponent<BoxCollider2D>().isTrigger= true;
                murito2.GetComponent<BoxCollider2D>().isTrigger= true;
                murito3.GetComponent<BoxCollider2D>().isTrigger= true;
                 StartCoroutine ("Muro");
               }
            }
                
        void OnTriggerEnter2D(Collider2D other)
   {    
       if(other.tag=="viento"){
           Debug.Log("hola");
       
            GetComponent<Rigidbody2D>().AddForce (new Vector2 (-1000,0));
       }
   
       
   }


         



    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump=false;
         

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
        yield return new WaitForSeconds(tiempo);
        runSpeed=60f;
    

    }

     IEnumerator CDRDash(){
        yield return new WaitForSeconds(2);
        CooldawnDash=false;
    

    }
    IEnumerator Muro(){
        yield return new WaitForSeconds(1);
        murito.GetComponent<BoxCollider2D>().isTrigger= false;
        murito1.GetComponent<BoxCollider2D>().isTrigger= false;
        murito2.GetComponent<BoxCollider2D>().isTrigger= false;
        murito3.GetComponent<BoxCollider2D>().isTrigger= false;
    

    }
}
