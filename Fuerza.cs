using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza : MonoBehaviour
{
    public float fuerza = 10f;
    
   
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * fuerza * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * fuerza * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * fuerza * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * fuerza * Time.deltaTime;
        }
    }
}
