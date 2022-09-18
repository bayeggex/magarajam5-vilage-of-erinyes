using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenloadmanager : MonoBehaviour
{
    void Start()
{
    
    StartCoroutine(zıbabuvj());
}

IEnumerator zıbabuvj()
{
    yield return new WaitForSeconds(40);
    SceneManager.LoadScene("2");
}
}
