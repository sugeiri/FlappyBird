using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cadenas : MonoBehaviour
{
	public float originZ;
	public float offsetZ = 0;
	public float wavelength = 0.25f;
	public float forwardSpeed = 1f;

	void Start()
	{
        if (Random.Range(0, 3) == 1)
        {
			gameObject.SetActive(false);
        }
		// remember the original positions you placed your gameobject
		originZ = this.transform.localRotation.z;
	}

	void Update()
	{
		float birdPos = this.transform.localRotation.z;
		offsetZ = Mathf.Sin(2 * Mathf.PI * Time.time) * wavelength; // move up and down
		birdPos = originZ + offsetZ;
		this.transform.localRotation = Quaternion.Euler(0, 0, birdPos);
	}
}
