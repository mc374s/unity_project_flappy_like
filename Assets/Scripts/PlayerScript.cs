using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    enum AudioNO {
        FLAP,
        FALL,
    };

    public Vector2 jumpForce = new Vector2(0, 300);
    private new Rigidbody2D rigidbody2D;
    private AudioSource audioSource;
    public AudioClip[] clips;
    

	// Use this for initialization
	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
            rigidbody2D.velocity = Vector2.zero;
            if (transform.position.x < 0) {
                jumpForce.x = 50;
            }else {
                jumpForce.x = 0;
            }
            rigidbody2D.AddForce(jumpForce);
            audioSource.clip = clips[(int)AudioNO.FLAP];
            audioSource.Play();
        }
        if(HPScript.HP <= 0) {
            StartCoroutine("Die");
        }
	}
    void OnTriggerEnter2D(Collider2D collision)  {
        if (collision.tag == "WALL"){
            StartCoroutine("Die");
        }
    }

    IEnumerator Die()
    {
        Debug.Log("Die!!!");
        audioSource.clip = clips[(int)AudioNO.FALL];
        audioSource.Play();
        //rigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
