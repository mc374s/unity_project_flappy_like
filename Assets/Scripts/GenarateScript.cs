using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenarateScript : MonoBehaviour {

    public GameObject obstacles;

	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateObstacles", 1.0f, 1.5f);
	}
	void CreateObstacles() {
        Instantiate(obstacles);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
