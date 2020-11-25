using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float velocidad;
    public GameObject moneda;
    // Start is called before the first frame update
    public float originY, originX;
    public float offsetY = 0, offsetX = 0;
    public float wavelength = 0;



    void Start()
    {
        originY = this.transform.position.y;
        originX = this.transform.position.x;
        if (Random.Range(0, 10) == 5)
        {
            moneda.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime;


        Vector3 birdPos = this.transform.position;
        offsetY = Mathf.Sin(2 * Mathf.PI * Time.time) * wavelength; // move up and down
        offsetX -= Time.deltaTime * velocidad; // move towards the player
        birdPos.y = originY + offsetY;
        birdPos.x = originX + offsetX;
        this.transform.position = birdPos;


    }
}
