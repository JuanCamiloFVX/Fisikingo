using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValorCaja2 : MonoBehaviour
{
    public static float valor2 = 1f;
    public string StringValor = "Caja 2: ";

    public Text TextValor;
    public static ValorCaja2 ValorC;
    public Rigidbody2D Masa;


    private void Awake()
    {
        ValorC = this;
        Masa = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                Masa.mass = Masa.mass + 0.1f;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                Masa.mass = Masa.mass - 0.1f;
            }
        }

        valor2 = Masa.mass;

        if (TextValor != null)
        {
            TextValor.text = StringValor + " " + valor2.ToString() + " Kg";
        }
    }
}

