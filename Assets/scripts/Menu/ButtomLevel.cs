using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtomLevel : MonoBehaviour
{
    public int costo = 100;//el costo para desbloquear el nivel
    public string nombre_nivel = "Principal";//el nombre del nivel, para buscarlo y cargar la escena
    public bool bloqueado = true;//si es true, el nivel esta bloqueado
    [Header("Configuracion de GUI")]
    public TextMeshProUGUI textoMoneda;
    public GameObject candado;
    public Image Fondo;
    public Menu mnSonido;

    public Color colorBloqueado;
    public Color colorDesbloqueado;



    void Start()
    {
        if (nombre_nivel == "Principal") 
        {
            bloqueado = false;//si es true, el nivel esta bloqueado
            ScoreManager.SetUnlockNivel(nombre_nivel, false);//se guarda que el nivel esta bloqueado
            Fondo.color = colorDesbloqueado;
            textoMoneda.text = "";
            candado.SetActive(false);
        }


        PlayerPrefs.SetInt("Coins", 100);
        int str = PlayerPrefs.GetInt(nombre_nivel,0);
        Debug.Log("nivel: "+ nombre_nivel + " null?: " + PlayerPrefs.HasKey(nombre_nivel));
        if (PlayerPrefs.HasKey(nombre_nivel)==false) {
            ScoreManager.SetUnlockNivel(nombre_nivel, true);//se guarda que el nivel esta bloqueado
            textoMoneda.text = costo.ToString();
            Fondo.color = colorBloqueado;
            candado.SetActive(true);
        }
        else
        {
            bloqueado = (ScoreManager.GetUnlockNivel(nombre_nivel) == 1) ? true : false;

            if (bloqueado)
            {
                Fondo.color = colorBloqueado;
                textoMoneda.text = costo.ToString();
                candado.SetActive(true);
            }
            else
            {
                Fondo.color = colorDesbloqueado;
                textoMoneda.text = "";
                candado.SetActive(false);
            }

        }
        
    }
    void Update()
    {
        Debug.Log("nivel: " + nombre_nivel + " null?: " + PlayerPrefs.HasKey(nombre_nivel));
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    public void TocarBoton()
    {
        if (bloqueado)//si el nivel esta bloqueado
        {
            ComprarNivel();
        }
        else
        {
            JugarNivel();
        }
    }

    void ComprarNivel()
    {
        if(ScoreManager.GetCoins()>= costo)
        {
            bloqueado = false;
            ScoreManager.SetUnlockNivel(nombre_nivel, bloqueado);
            ScoreManager.SetCoins(-costo);
            Fondo.color = colorDesbloqueado;
            textoMoneda.text = "";
            candado.SetActive(false);
            PlayerPrefs.Save();
        }

    }
    void JugarNivel()
    {

        
        SceneManager.LoadScene(nombre_nivel);
        
        
    }
}
