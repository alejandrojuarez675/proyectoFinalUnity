﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {

	public float speed = 100f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, speed * Time.deltaTime);

		float limiteTamanio = 25f;
		float paso = .1f;
		if (transform.localScale.x <= limiteTamanio)
		{
		transform.localScale += new Vector3(paso,paso,paso);
		}
	}
}