using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotOfPandulumScript : MonoBehaviour {
    private float angleZ;
    private float angleIncrement;
    public float angleLimit;
	// Use this for initialization
	void Start () {
        angleZ = 0;
        angleIncrement = Random.Range(1.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
        angleZ += angleIncrement;
        if(angleZ <= -angleLimit || angleZ >= angleLimit) {
            angleIncrement = -angleIncrement;
        }

        transform.rotation = Quaternion.Euler(0, 0, angleZ);
        //if(angleZ > 360) {
        //    angleZ = 0.0f;
        //}
	}
}
