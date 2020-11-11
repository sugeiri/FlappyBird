using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class AreaPuntaje : MonoBehaviour
{
    public ControlEscena escena;
    void Start()
    {
    }
    private void OnTiggerEnter2D(Collision2D colision)
    {
        Puntaje.aa_puntaje++;
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
