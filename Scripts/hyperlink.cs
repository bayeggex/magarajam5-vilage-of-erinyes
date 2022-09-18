using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyperlink : MonoBehaviour
{
    public void Youtube(){
        Application.OpenURL("https://www.youtube.com/channel/UCBQXlwhjwxaEdUlCY42zvMg");
    }
    public void OpenURL(string link){
        Application.OpenURL(link);
    }
}
