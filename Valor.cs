using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;


public class Valor : MonoBehaviour
{
    public static float valor = 1f;
    public string StringValor = "Caja 1: ";

    public Text TextValor;
    public static Valor ValorC;
    public Rigidbody2D Masa;
    

    private void Awake()
    {
        ValorC = this;
        Masa = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
        
    }
    void Update()
    { 
        if(Input.GetKey(KeyCode.K)){

         if (Input.GetKey(KeyCode.UpArrow))
            {
                Masa.mass = Masa.mass + 0.1f;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                Masa.mass = Masa.mass - 0.1f;
            }
        }

        valor = Masa.mass;

        if (TextValor != null)
        {
            TextValor.text = StringValor +" " +valor.ToString()+" Kg";
        }
    }
}
