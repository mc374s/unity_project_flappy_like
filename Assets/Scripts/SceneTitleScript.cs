using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneTitleScript : MonoBehaviour {

    public Scene sceneMain;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine("StartSceneMain");
        }
    }

    IEnumerator StartSceneMain()
    {
        Debug.Log("Start!!!");
        //rigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(sceneMain.name);
    }
}
