using UnityEngine;
using System.Collections;

public class VolleyBall : MonoBehaviour
{
	Vector3 startingPosOne;
	Vector3 startingPosTwo;
	Rigidbody2D rb2D;
	public float maxSpeed;

	void Awake()
	{
		rb2D = GetComponent<Rigidbody2D>();
	}

	// Use this for initialization
	void Start()
	{
		startingPosOne = Player1Controller.Player1.transform.position;
		startingPosTwo = Player2Controller.Player2.transform.position;
	}

	void FixedUpdate()
	{
		if (rb2D.velocity.magnitude > maxSpeed)
		{
			rb2D.velocity = rb2D.velocity.normalized * maxSpeed;
		}
	}

	// Update is called once per frame
	void Update()
	{
		//unneeded
		//Debug.Log(rb2D.velocity.magnitude);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Floor" && (transform.position.x < 0))
		{
			
			Score.score.IncrementPlayer2Score ();
			Player1Controller.Player1.transform.position = startingPosOne;
			transform.position = Player1Controller.Player1.transform.position + Vector3.up * 10f;

			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
		}

		if (col.gameObject.tag == "Floor" && (transform.position.x > 0))
		{
			
			Score.score.IncrementPlayer1Score ();
			Player2Controller.Player2.transform.position = startingPosTwo;
			transform.position = Player2Controller.Player2.transform.position + Vector3.up * 10f;

			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
		}
	}
}