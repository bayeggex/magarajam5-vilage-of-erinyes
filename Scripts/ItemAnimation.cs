using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ItemAnimation : MonoBehaviour
{
    public GameObject Item;
    private Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();
    }
    
    void Update(){
        
        if(Input.GetButtonDown("Fire1")){          
            anim.SetBool("flosh", true);
            
        }

        else{
            anim.SetBool("flosh", false);
        }
    }

}
