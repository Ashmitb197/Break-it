using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballstart : MonoBehaviour {
	[SerializeField] private PhysicsMaterial2D	ballMat;
	public Rigidbody2D rb;
	private string collname;
	[SerializeField] private GameObject game_over;

	public bool lost;
	public int count;
	private GameObject[] gos;
	public bool won;

	public GameObject wonCanvas;

	void Start()
	{
		gos = GameObject.FindGameObjectsWithTag("Obstacles");
		count = gos.Length;
		game_over.SetActive(false);
		wonCanvas.SetActive(false);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.collider.name == "Quad (2)")
		{
			game_over.SetActive(true);
			lost = true;
			rb.linearVelocity = new Vector2 (0,0);
			
			//SceneManager.LoadScene("Start");
		}
		else if(collision.collider.name == "Quad (1)")
		{
			rb.linearVelocity = new Vector2(-10f,Random.Range(-10,20));
		}
		else if(collision.collider.name == "Quad")
		{
			rb.linearVelocity = new Vector2(10f,Random.Range(-10,20));
		}
		else if(collision.collider.name == "Quad (3)")
		{
			rb.linearVelocity = new Vector2(Random.Range(-10,10), -5);
		}
		else if(collision.collider.tag == "Obstacles")
		{
			rb.linearVelocity = new Vector2(Random.Range(-7,7),Random.Range(-3,5));
		}
		else{
			//Time.timeScale = 1;
			rb.linearVelocity = new Vector2(Random.Range(-10,10), 7f);

		}


		if(collision.collider.name == "Player_Block")
		{
			if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
			{	
				rb.linearVelocity = new Vector2(10f, 15f);
			}
			else if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
			{
				rb.linearVelocity = new Vector2(-10f, 15f);
			}
			else{
				rb.linearVelocity = new Vector2(Random.Range(-10,10), 15f);
			}

		}


		if(collision.collider.tag == "Obstacles")
		{
			
			collname = collision.collider.name;
			Destroy(GameObject.Find(collname));
			count--;
			if (count <= 0)
			{
				gamewon();
				won = true;
			}
			Debug.Log(count);


		}
	}

	public void gamewon()
	{
		Time.timeScale = 0;
		wonCanvas.SetActive(true);
	}
}
