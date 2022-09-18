using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuloader : MonoBehaviour
{
    public void cikis(){
        Application.Quit();
        print("çıkış yapıldı");
    }
    public void basla(){
        SceneManager.LoadScene("1");
    }
    public void assetler(){
        Application.OpenURL("https://bayeggex.itch.io/Vilage-of-Erinyes");
    }
}
