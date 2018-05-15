using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public Vector2 jumpForce = new Vector2(0, 300);
    private new Rigidbody2D rigidbody2D;
    private AudioSource audioFlap;

    //private bool isDead = false;

	// Use this for initialization
	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        audioFlap = GetComponent<AudioSource>();
        //isDead = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(jumpForce);
            audioFlap.Play();
        }
        //if(isDead) {
        //    rigidbody2D.velocity = Vector2.zero;
        //}
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "WALL" || collision.tag == "OBSTACLE")
        {
            //isDead = true;
            StartCoroutine("Die");
        }
    }

    IEnumerator Die()
    {
        Debug.Log("Die!!!");
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
