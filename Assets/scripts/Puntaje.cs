using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Puntaje : MonoBehaviour
{
    public static int aa_puntaje = 0;
    public static int distan = 0;

    [Header("Textos en juego")]
    public TextMeshProUGUI monedasEnJuego;
    public TextMeshProUGUI distanciaEnJuego;

    [Header("Textos en menu de gameover")]
    public TextMeshProUGUI monedas;
    public TextMeshProUGUI Distancia;
    public TextMeshProUGUI MejorDistancia;

    void Start()
    {
        aa_puntaje = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Distancia: " + distan);
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.DeleteAll();
        }
        if (ControlEscena.GameStatus == "inicio")
        {
            monedasEnJuego.text = aa_puntaje.ToString();
            distanciaEnJuego.text = distan.ToString();
        }
        else
        if (ControlEscena.GameStatus == "perdiste")
        {
            monedas.text = "Coins:" + monedasEnJuego.text;
            Distancia.text = "Score:" + distanciaEnJuego.text;




            int str = PlayerPrefs.GetInt("Distancia", 0);
            if (str == 1)
            {
                MejorDistancia.text = "Best:" + distan;
                ScoreManager.SetMejorDistancia(SceneManager.GetActiveScene().name, distan);
            }
            else
            {

                if (distan > ScoreManager.GetMejorDistancia(SceneManager.GetActiveScene().name))
                {
                    MejorDistancia.text = "Best:" + Distancia.text;
                    ScoreManager.SetMejorDistancia(SceneManager.GetActiveScene().name, distan);
                }
                else
                {
                    MejorDistancia.text = "Best:" + ScoreManager.GetMejorDistancia(SceneManager.GetActiveScene().name).ToString();
                }
            }
        }

    }
}
