using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    
    public void Cambiodescene(string nombre)
    {
        print("Cargardo scene" + nombre);
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {


        Application.Quit();

        print("Saliendo");
        Application.Quit();
    }

    public void Reiniciar(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

}
