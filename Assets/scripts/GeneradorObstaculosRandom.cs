﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObstaculosRandom : MonoBehaviour
{
    public float tiempoMax = 1;
    private float tiempoIncial = 0;
    public GameObject[] obstaculos;
    public float altura;
    int max_obs = 10;//los segundos para destruir los objetos fuera de pantalla
    // Start is called before the first frame update
    void Start()
    {
        // GameObject obstaculoNuevo = Instantiate(obstaculo);
        // obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
        //Destroy(gameObject,max_obs);

    }

    // Update is called once per frame
    void Update()
    {
        if (ControlEscena.GameStatus == "inicio")
        {
            if (tiempoIncial > tiempoMax)
            {
                ;
                GameObject obstaculoNuevo = Instantiate(obstaculos[Random.Range(0, obstaculos.Length)]);
                obstaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura),0);
                Destroy(obstaculoNuevo, max_obs);
                tiempoIncial = 0;
            }
            else
            {
                tiempoIncial += Time.deltaTime;
            }
        }


    }
}