using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour
{
	public static Player1Controller Player1;

	public float jumpHeight;
	public bool isGrounded;
	Rigidbody2D rb2Dplayer1;

	void Awake()
	{
		Player1 = this;
		rb2Dplayer1 = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (transform.position.y <= -6.6f)
			isGrounded = true;

		if (isGrounded && Input.GetKeyDown(KeyCode.W))
		{
			rb2Dplayer1.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
			isGrounded = false;
		}


			float h = Input.GetAxis("Horizontal1");
			rb2Dplayer1.AddForce((Vector2.right * 1000.0f) * h);
		


		if (rb2Dplayer1.velocity.x > 0.0f || rb2Dplayer1.velocity.x < 0.0f)
			rb2Dplayer1.velocity = Vector2.MoveTowards(rb2Dplayer1.velocity, new Vector2(0, rb2Dplayer1.velocity.y), 100.0f);
	}


}
