using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETA : MonoBehaviour
{
public CharacterController2D player;

public float FuerzaSalto;

  

      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
             player.m_JumpForce=FuerzaSalto;
           
            
        }
    }

    void OnTriggerExit2D(Collider2D obj){
        if(obj.tag=="Player"){
             
             player.m_JumpForce=300f;
           
            
        }
    }
    
}
