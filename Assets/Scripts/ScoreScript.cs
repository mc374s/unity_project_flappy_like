using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public Text scoreText;
    public static int score;

    public Text highScoreText;
    public static int highScore = 0;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "SCORE:" + score;
        highScoreText.text = "HIGH-SCORE:" + highScore;

        if(score >= highScore) {
            highScore = score;
        }
	}
}
