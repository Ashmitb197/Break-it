using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movements : MonoBehaviour {

	public Rigidbody2D rb;
	public Transform transform;
	public float speed;
	public GameObject player;
	
	public GameObject ballScript;
	public GameObject pauseGame;

	// Update is called once per frame

	void Update () {

		if(ballScript.GetComponent<ballstart>().lost == false)
		{
			lftrt();
		}
		
		if(Input.GetKey(KeyCode.Escape) && ballScript.GetComponent<ballstart>().lost == false && ballScript.GetComponent<ballstart>().won == false)
		{
			Time.timeScale = 0;
			pauseGame.SetActive(true);
		}
	}


	public void lftrt()
	{
		if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
		{
			player.transform.Translate(0.3f,0,0);
		}
		else if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
		{
			player.transform.Translate(-0.3f,0,0);
		}

	}

}
