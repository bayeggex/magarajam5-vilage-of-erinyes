using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastSword : MonoBehaviour
{
   public float damage = 10f;
   public float range = 1f;
   public Camera cam;

    void Update() {
      if(Input.GetButtonDown("Fire1")){
         Shoot();
      }
   }

   void Shoot(){
    RaycastHit hit;
    if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 1)){
       enemy ENEMY = hit.transform.GetComponent<enemy>();
       if(ENEMY != null){
        ENEMY.TargetHit(damage);
       }
    }

   }
    
}
