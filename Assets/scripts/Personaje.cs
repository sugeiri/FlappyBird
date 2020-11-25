using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    
    public float velocidad = 1;
    private Rigidbody2D rb;
    public ControlEscena escena;
    AudioSource fuenteDeAudio;
    public AudioClip punto;
    public AudioClip Golpe;

    // Start is called before the first frame update
    void Start()
    {
        fuenteDeAudio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocidad;
        }
       


    }
    void OnCollisionEnter2D(Collision2D micolision)
    {
 
        if (micolision.gameObject.name == "Moneda")
        {
                ScoreManager.SetCoins(1);
                Puntaje.aa_puntaje++;
                fuenteDeAudio.clip = punto;
                fuenteDeAudio.Play();
                Destroy(micolision.gameObject);
         }
        else
        {
                fuenteDeAudio.clip = Golpe;
                fuenteDeAudio.Play();
                escena.Perdiste();        
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "AreaPuntaje")
        {
            Puntaje.distan++;
        }
        
    }

}
