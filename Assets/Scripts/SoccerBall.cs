using UnityEngine;
using System.Collections;

public class SoccerBall : MonoBehaviour
{
	Vector3 startingPosOne;
	Vector3 startingPosTwo;
	Vector3 ballStartingPos;
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
		ballStartingPos = rb2D.transform.position;
	}

	void FixedUpdate()
	{
		if (rb2D.velocity.magnitude > maxSpeed)
		{
			rb2D.velocity = rb2D.velocity.normalized * maxSpeed;
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Floor" && (transform.position.x < 0))
		{

			Score.score.IncrementPlayer2Score ();
			Player1Controller.Player1.transform.position = startingPosOne;
			Player2Controller.Player2.transform.position = startingPosTwo;
			transform.position = ballStartingPos;

			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
		}

		if (col.gameObject.tag == "Floor" && (transform.position.x > 0))
		{

			Score.score.IncrementPlayer1Score ();
			Player1Controller.Player1.transform.position = startingPosOne;
			Player2Controller.Player2.transform.position = startingPosTwo;
			transform.position = ballStartingPos;
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
		}
	}
}