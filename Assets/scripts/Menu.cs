using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{

    [Header("Configuracion menu de inicio")]
    public TextMeshProUGUI textoMonedas;
    public AudioClip swipeMenu;//

    public AudioSource As;//audiosource
    void Start()
    {
        textoMonedas.text = ScoreManager.GetCoins().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (textoMonedas.text != ScoreManager.GetCoins().ToString())
        {
            textoMonedas.text = ScoreManager.GetCoins().ToString();
        }
    }

    public void CargarNivel(string nivel)
    {
        SceneManager.LoadScene(nivel);
        //SceneManager.GetSceneByName(nivel);
        //SceneManager.LoadScene(SceneManager.GetSceneByName(nivel));
        //Time.timeScale = 1;
    }

    public void SwipeSonido()
    {
        As.clip = swipeMenu;
        As.Play();
    }


}
