using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
{
    public string Url= "www.google.com";
    public void AbrirURL()
    {
        Application.OpenURL(Url);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
