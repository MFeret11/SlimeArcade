using UnityEngine;
using System.Collections;

public class RandomBall : MonoBehaviour
{
	Vector3 startingPosOne;
	Vector3 startingPosTwo;
	Vector3 ballStartingPos;
	Rigidbody2D rb2D;
	public float maxSpeed;
	Vector2 randomDirection;

	void Awake()
	{
		rb2D = GetComponent<Rigidbody2D>();
		randomDirection = new Vector2(Random.value, Random.value);
	}

	// Use this for initialization
	void Start()
	{
		startingPosOne = Player1Controller.Player1.transform.position;
		startingPosTwo = Player2Controller.Player2.transform.position;
		ballStartingPos = rb2D.transform.position;
		rb2D.AddForce (randomDirection * 1000f);
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
		if (col.gameObject.tag == "Player 1")
		{

			Score.score.IncrementPlayer2Score ();
			Player1Controller.Player1.transform.position = startingPosOne;
			Player2Controller.Player2.transform.position = startingPosTwo;
			transform.position = ballStartingPos;

			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
			randomDirection = new Vector2(Random.value, Random.value);
			rb2D.AddForce (randomDirection * 1000f);
		}

		if (col.gameObject.tag == "Player 2")
		{

			Score.score.IncrementPlayer1Score ();
			Player1Controller.Player1.transform.position = startingPosOne;
			Player2Controller.Player2.transform.position = startingPosTwo;
			transform.position = ballStartingPos;
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
			randomDirection = new Vector2(Random.value, Random.value);
			rb2D.AddForce (randomDirection * 1000f);
		}
	}
}
