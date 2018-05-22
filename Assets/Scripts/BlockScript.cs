using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {

    private AudioSource audioHitted;

	// Use this for initialization
	void Start () {
        audioHitted = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        audioHitted.Play();
        HPScript.HP--;
    }
}
