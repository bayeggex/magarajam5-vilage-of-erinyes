using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float health = 50f;
    [SerializeField] private AudioSource dead;
    
    private void Start() {
        
    }

    public void TargetHit(float damage){
        health -= damage;

        if(health <= 0){
            GetComponent<CapsuleCollider>().enabled = false;
            Destroy(this.gameObject);
            die();
        }
    }
    public void die(){
        dead.Play();
        print("oyuncu ölmüştür bir fatiha okuyun");
    }
}
