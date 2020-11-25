using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ControlEscena : MonoBehaviour
{
    public GameObject canvas_perdiste;
    public GameObject canvas_puntos;//Puntos en juego

    public GameObject panel_tapJuego;//ventana de tap para iniciar juego
    public GameObject jugador;//el jugador



    [Header("Configuracion menu de inicio")]
    public TextMeshProUGUI textoMonedas;

    public static string GameStatus="pausa";//pasa saber el esatus del juego
    void Start()
    {
        if (SceneManager.GetActiveScene().name.ToString() != "inicio")
        {
            Time.timeScale = 1;
            jugador.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

        }
        else
        {
            textoMonedas.text = ScoreManager.GetCoins().ToString();
        }
            


    }
    public void Perdiste()
    {
        
        GameStatus = "perdiste";
        canvas_perdiste.SetActive(true);
        canvas_puntos.SetActive(false);
        Time.timeScale = 0;
    }
    
    public void Reiniciar()
    {
        Puntaje.aa_puntaje = 0;
        Puntaje.distan = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Time.timeScale = 1;
    }

    public void MenuInicio()
    {
        Puntaje.aa_puntaje = 0;
        Puntaje.distan = 0;
        SceneManager.LoadScene("inicio");
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name.ToString() == "inicio")//si la escena es la de menu de inicio se podra cumplir
        {

        }
        else {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))//cuando se preciosa eso, el juego inicia
            {
                if (jugador.GetComponent<Rigidbody2D>().bodyType != RigidbodyType2D.Dynamic)
                {
                    jugador.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    panel_tapJuego.SetActive(false);
                    canvas_puntos.SetActive(true);
                    GameStatus = "inicio";
                }
            }


        }
        
    }
}
