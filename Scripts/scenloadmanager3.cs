using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenloadmanager3 : MonoBehaviour
{
    void Start()
{
    
    StartCoroutine(zıbabuvj3());
}

IEnumerator zıbabuvj3()
{
    yield return new WaitForSeconds(42);
    SceneManager.LoadScene("Menu");
}
}
