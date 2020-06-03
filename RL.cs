using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RL : MonoBehaviour
{

    public Text Usuario, Password, Excepcion, Cpassword, UsuarioL,PasswordL;

    public object Leer { get; private set; }

    public void Registrar()
    {
        //Regirtra los Usuarios
        using (StreamWriter Escribir = new StreamWriter("Usuarios.txt", true))

                if (Password.text == Cpassword.text) {

                        Escribir.WriteLine(Usuario.text+","+Password.text);

                Excepcion.text = "Registro Exitoso";
                
            }
            else
            {
                Excepcion.text = "Las Passwords no coinciden";
            }
    }

    public void Cargar(string nombre)
    {
       
        string[] campos = new string[2];
        string Cadena;

        int Nline;
        Nline = File.ReadAllLines("Usuarios.txt").Length;

        using (StreamReader Leer = new StreamReader("Usuarios.txt"))

            //Lee Y confima la existencia del usuario
            for (int i = 0; i < Nline; i++) {

                Cadena = Leer.ReadLine();

                campos = Cadena.Split(',');

                if (campos[0] == UsuarioL.text)
                {
                    if(campos[1] == PasswordL.text)
                    {
                        SceneManager.LoadScene(nombre);
                    }
                        
                }
                else
                {
                    Excepcion.text = "Usuario o Password incorrectos";

                }
            }
            
   
            
    }
           

    
    } 
              
    






