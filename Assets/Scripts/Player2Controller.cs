using UnityEngine;
using System.Collections;

public class Player2Controller : MonoBehaviour
{
	public static Player2Controller Player2;

	public float jumpHeight;
	public bool isGrounded;
	Rigidbody2D rb2Dplayer2;

	void Awake()
	{
		Player2 = this;
		rb2Dplayer2 = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (transform.position.y <= -6.6f)
			isGrounded = true;

		if (isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
		{
			rb2Dplayer2.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
			isGrounded = false;
		}


			float h = Input.GetAxis("Horizontal2");
			rb2Dplayer2.AddForce((Vector2.right * 1000.0f) * h);
		


		if (rb2Dplayer2.velocity.x > 0.0f || rb2Dplayer2.velocity.x < 0.0f)
			rb2Dplayer2.velocity = Vector2.MoveTowards(rb2Dplayer2.velocity, new Vector2(0, rb2Dplayer2.velocity.y), 100.0f);
	}


}
