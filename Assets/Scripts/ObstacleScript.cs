using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

    public Vector2 velocity = new Vector2(-4.0f, 0.0f);


	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = velocity;
        transform.position = new Vector3(transform.position.x, transform.position.y + Random.Range(-2.0f, 2.0f), transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
