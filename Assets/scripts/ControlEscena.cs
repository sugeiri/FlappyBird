using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlEscena : MonoBehaviour
{
    public GameObject canvas_perdiste;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        
    }
    public void Perdiste()
    {
        canvas_perdiste.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void Reiniciar()
    {
        SceneManager.LoadScene(1);
        //Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        //SceneManager.LoadScene(0);
    }
}
