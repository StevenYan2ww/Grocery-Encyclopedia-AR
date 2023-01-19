using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowandHIde : MonoBehaviour
{
    // Start is called before the first frame update

    public void showObj(GameObject obj){
        obj.SetActive(true);
    }

    public void hideIt(GameObject obj){
        obj.SetActive(false);
    }

   
}
