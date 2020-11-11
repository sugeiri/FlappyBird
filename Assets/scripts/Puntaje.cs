using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Puntaje : MonoBehaviour
{
    public static int aa_puntaje = 0;
    
    void Start()
    {
        aa_puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = aa_puntaje.ToString();

    }
}
