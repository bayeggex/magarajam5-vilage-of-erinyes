using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenloadmanager2 : MonoBehaviour
{
    void Start()
{
   
    StartCoroutine(zıbabuvj2());
}

IEnumerator zıbabuvj2()
{
    yield return new WaitForSeconds(14);
    SceneManager.LoadScene("3");
}
}
