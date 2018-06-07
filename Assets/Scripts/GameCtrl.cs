using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameCtrl : MonoBehaviour {

	public static GameCtrl instance;
	public Text scoreText;
	public GameObject overtext;
	public bool gameOver = false;
	public float scrollspeed = -1.5f;

	private int score = 0;
	private int highScore = 0;

	// Use this for initialization
	void Awake () {

		if (instance == null) {
		
			instance = this;
		} else if (instance != this) {
		
		
			Destroy (gameObject);
		}
	
	}
	
	// Update is called once per frame
	void Start() {

		highScore = PlayerPrefs.GetInt ("highScore", 0);
	}
	void OnDestroy (){

		PlayerPrefs.SetInt ("highScore", highScore);
		}


	void Update () {

		if (gameOver == true && Input.GetMouseButtonDown (0)) {
		
		
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	
	}
	public void Scored()
	{

		if (gameOver)
			return;

		//scoreA = scoreA +1 ;
		//scoreText.Text= "Score: " + score.ToString ();
	}

	public void BirdScored()
	{
		if (gameOver) {

			return;
		}
		score++;

		if (score > highScore) {

			highScore = score;
		}
		//scoreText.text = "Score: " + score.ToString ();
		scoreText.text = "Score: " + score + "\nhigh Score: " + highScore;
	}

	public void PlaneCrash (){

		overtext.SetActive (true);
		gameOver = true;
	}
		
}
