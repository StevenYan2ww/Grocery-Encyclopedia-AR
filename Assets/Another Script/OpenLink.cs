using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public string Urlink;

    public void Open(){
        Application.OpenURL(Urlink);
    }
    // Start is called before the first frame update
   
}
