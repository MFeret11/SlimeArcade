using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	public static Score score;
	public int Player1Score = 0;
	public int Player2Score = 0;
	public Text Player1ScoreText;
	public Text Player2ScoreText;
	public int winningScore = 4;

	void Awake()
	{
		GameObject MenuCanvas = GameObject.Find ("MenuCanvas");
		MenuCanvas.GetComponent<Canvas> ().enabled = true;
		Time.timeScale = 0.0f;


		score = this;
		Player1ScoreText.text = Player1Score.ToString ();
		Player2ScoreText.text = Player2Score.ToString ();
	}

	public void IncrementPlayer1Score()
	{
		Player1Score++;
		Player1ScoreText.text = Player1Score.ToString ();
		if (Player1Score > winningScore) {
			GameObject GOCanvas = GameObject.Find ("GameOverCanvas1");
			GOCanvas.GetComponent<Canvas> ().enabled = true;
			Time.timeScale = 0.0f;
		}		
	}

	public void IncrementPlayer2Score()
	{
		Player2Score++;
		Player2ScoreText.text = Player2Score.ToString ();
		if (Player2Score > winningScore) {
			GameObject GOCanvas = GameObject.Find ("GameOverCanvas2");
			GOCanvas.GetComponent<Canvas> ().enabled = true;
			Time.timeScale = 0.0f;
		}		
	}

	public void LoadVolleyBall(){
		Time.timeScale = 1.0f;
		SceneManager.LoadScene("VolleyBallScene");
	}
	public void LoadMainMenu(){
		Time.timeScale = 1.0f;
		SceneManager.LoadScene("MainScene");
	}
	public void LoadSoccer() {
		Time.timeScale = 1.0f;
		SceneManager.LoadScene("SoccerScene");

	}
	public void LoadDodgeBall(){
		//Debug.Log ("PingPong Pressed!");
		Time.timeScale = 1.0f;
		SceneManager.LoadScene ("DodgeBallScene");

	}
	public void MainCanvasDisable(){
		GameObject MenuCanvas = GameObject.Find ("MenuCanvas");
		MenuCanvas.GetComponent<Canvas> ().enabled = false;
		Time.timeScale = 1.0f;
	}

}
