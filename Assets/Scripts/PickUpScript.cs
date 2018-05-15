﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PLAYER")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Renderer>().enabled = false;
            ScoreScript.score++;
        }
    }
}
