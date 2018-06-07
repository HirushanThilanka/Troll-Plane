﻿using UnityEngine;
using System.Collections;

public class startScreen : MonoBehaviour {

	static bool sawOnce = true;

	// Use this for initialization
	void Start () {

		if (sawOnce) {

			GetComponent<SpriteRenderer> ().enabled = false;
			Time.timeScale = 0;
		}

		sawOnce = false;

	}

	// Update is called once per frame
	void Update () {

		if (Time.timeScale == 0 && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown (0)) ) 
		{
			Time.timeScale = 1;
			GetComponent<SpriteRenderer> ().enabled = false; 


		}

	}
}
