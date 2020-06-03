using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public string Stringscore  = "Score: ";
    public string StringRecord = "Record: ";

    public Text Textscore;
    public Text Record;
    public static Score ValorC;

    private void Awake()
    {
        ValorC = this;
    }

    private void Start()
    {
        //using (StreamReader leer = new StreamReader("Record.txt"))

        //Record.text = StringRecord + " " + leer.ReadLine();

        Record.text = StringRecord + " " + PlayerPrefs.GetInt("PuntajeRecord", 0);
    }
    public void Sumar()
    {
        //Añade los Puntos
        score = score + 25;

        if (score > PlayerPrefs.GetInt("PuntajeRecord", 0))
        {
            PlayerPrefs.SetInt("PuntajeRecord", score);

            Record.text = StringRecord + " " + score.ToString();
        }
        
    }
    void Update()
    {
        if(Textscore != null)
        {
          Textscore.text = Stringscore + " " + score.ToString();
        }
       
    }
}

       