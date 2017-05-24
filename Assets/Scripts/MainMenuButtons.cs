using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour {

	public void VB_Button () {
		Time.timeScale = 1.0f;
		SceneManager.LoadScene("VolleyBallScene");
	}
	
	public void Soccer_Button () {
		Time.timeScale = 1.0f;
		SceneManager.LoadScene("SoccerScene");
	
	}
	public void Dodge_Ball_Button (){
		//Debug.Log ("PingPong Pressed!");
		Time.timeScale = 1.0f;
		SceneManager.LoadScene ("DodgeBallScene");

	}
}
