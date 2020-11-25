using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OstaculoVolador : MonoBehaviour
{
	public float originY, originX;
	public float offsetY = 0, offsetX = 0;
	public float wavelength = 0.25f;
	public float forwardSpeed = 1f;

	void Start()
	{
		// remember the original positions you placed your gameobject
		originY = this.transform.position.y;
		originX = this.transform.position.x;
	}

	void Update()
	{
		Vector3 birdPos = this.transform.position;
		offsetY = Mathf.Sin(2 * Mathf.PI * Time.time) * wavelength; // move up and down
		offsetX -= Time.deltaTime * forwardSpeed; // move towards the player
		birdPos.y = originY + offsetY;
		birdPos.x = originX + offsetX;
		this.transform.position = birdPos;
	}
}
