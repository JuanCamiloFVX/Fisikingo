using System.Collections;
using System.Collections.Generic;
//using UnityEditor.UIElements;

using UnityEngine;

public class GirarCircle : MonoBehaviour
{
    public int speed;
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.back, speed * Time.deltaTime);
    }
}
