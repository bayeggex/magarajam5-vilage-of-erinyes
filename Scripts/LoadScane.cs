using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScane : MonoBehaviour
{
   private void Update() {
        SkipStage();
    }

    public void SkipStage(){
       if(Input.GetKeyDown(KeyCode.F))
        SceneManager.LoadScene("Menu");
       
       if(Input.GetKeyDown(KeyCode.G)){
        SceneManager.LoadScene("1");
       }
       
       if(Input.GetKeyDown(KeyCode.H)){
        SceneManager.LoadScene("2");
       }
       
       if(Input.GetKeyDown(KeyCode.J)){
        SceneManager.LoadScene("4");
       }
       
       if(Input.GetKeyDown(KeyCode.K))
        SceneManager.LoadScene("3");
       
       if(Input.GetKeyDown(KeyCode.L))
        SceneManager.LoadScene("6");

    }
   
   private void OnTriggerEnter(Collider other) {
     SceneManager.LoadScene("4");
   }
}
