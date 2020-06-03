using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scenemanger : MonoBehaviour
{
    public Text Excepcion, Usuario, Password, Cpassword;
  
    [SerializeField] private GameObject m_LoginUI = null;
    [SerializeField] private GameObject m_Register = null;
    public void ShowLogin()
    {
        if (Excepcion.text != "Las Passwords no coinciden")
        {
            m_LoginUI.SetActive(true);
            m_Register.SetActive(false);
        }
            

    }
    public void Limpiar()
    {
            
       
    }
    public void ShowRegister()
    {
        
            m_LoginUI.SetActive(false);
            m_Register.SetActive(true);
            
    }









}