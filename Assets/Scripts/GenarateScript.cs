using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenarateScript : MonoBehaviour {

    public GameObject[] obstacles;

	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateObstacles", 1.0f, 1.5f);
	}
	void CreateObstacles() {
        if (ScoreScript.score > 30)
        {
            if (Random.Range(0, 100) < 80)
            {
                Instantiate(obstacles[1]);
                return;
            }
        }
        else if (ScoreScript.score > 10){
            if (Random.Range(0, 100) < 70)
            {
                Instantiate(obstacles[1]);
                return;
            }
        }
        else if(ScoreScript.score > 5) {
            if(Random.Range(0,100) < 60) {
                Instantiate(obstacles[1]);
                return;
            }
        }
        Instantiate(obstacles[0]);

    }

	// Update is called once per frame
	void Update () {
		
	}
}
