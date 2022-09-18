using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScript : MonoBehaviour
{
     [SerializeField] private AudioSource dead;
    private void Update() {
        loadObj();
    }

    public void loadObj(){
       if(Input.GetKeyDown(KeyCode.R)){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       }
    }
    private void OnTriggerEnter(Collider other){
       dead.Play();
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
