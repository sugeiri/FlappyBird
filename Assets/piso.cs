using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class piso : MonoBehaviour
{
    // Scroll the main texture based on time

    public float scrollSpeed = 0.5f;

    public Vector2 ScrollSpeed;

    private void OnEnable()
    {
        GetComponent<SpriteRenderer>().material.SetVector("_ScrollSpeed", ScrollSpeed);
    }
}
