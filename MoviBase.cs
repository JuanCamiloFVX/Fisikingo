using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviBase : MonoBehaviour
{
    public float Velocidad = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * Velocidad * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * Velocidad * Time.deltaTime;
            }
        }
    }
}
