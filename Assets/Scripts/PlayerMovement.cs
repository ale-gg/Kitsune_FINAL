using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed;
    public float Speed;
    public float tiempo;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public bool poder1;
    public bool CooldawnDash;
     public float Gravedad;
    public GameObject murito;
    public GameObject murito1;
    public GameObject murito2;
    public GameObject murito3;
  
    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        //animation
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
            GetComponent<Rigidbody2D>().gravityScale = 0;
            StartCoroutine ("Esperar2");

        }

         if(Input.GetButtonUp("Jump")){
             StartCoroutine ("Esperar");
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

         if(Input.GetKeyDown(KeyCode.LeftShift)&& poder1==true && CooldawnDash==false){
             runSpeed= Speed;
                CooldawnDash=true;
                StartCoroutine ("EsperarDash");
                StartCoroutine ("CDRDash");

         }


      

    }

      
        
        
         void OnTriggerStay2D(Collider2D other){
           if(poder1==true){
               if(runSpeed==600){
                murito.GetComponent<BoxCollider2D>().isTrigger= true;
                murito1.GetComponent<BoxCollider2D>().isTrigger= true;
                murito2.GetComponent<BoxCollider2D>().isTrigger= true;
                murito3.GetComponent<BoxCollider2D>().isTrigger= true;
                 StartCoroutine ("Muro");
               }
        }
    }

    //eliminar la animación de jump cuando está cayendo
    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
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
        runSpeed=115f;
    

    }

     IEnumerator CDRDash(){
        yield return new WaitForSeconds(3);
        CooldawnDash=false;
    

    }

    IEnumerator Muro(){
        yield return new WaitForSeconds(1);
        murito.GetComponent<BoxCollider2D>().isTrigger= false;
        murito1.GetComponent<BoxCollider2D>().isTrigger= false;
        murito2.GetComponent<BoxCollider2D>().isTrigger= false;
        murito3.GetComponent<BoxCollider2D>().isTrigger= false;
    

    }


   

    
    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
