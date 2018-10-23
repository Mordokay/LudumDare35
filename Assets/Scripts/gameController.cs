using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour {

    public int numberOfPoints;
    public int numberOfLives;
    public int highScore;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;

    public Text scoreText;
    public Text highScoreText;

    // Use this for initialization
    void Start () {
        numberOfPoints = 0;
        numberOfLives = 3;
        highScore = PlayerPrefs.GetInt("highscore");
    }
	
	// Update is called once per frame
	void Update () {
        if (numberOfPoints > highScore)
        {           
            highScore = numberOfPoints;
            PlayerPrefs.SetInt("highscore", highScore);
        }

        scoreText.text = "SCORE: " + numberOfPoints;
        highScoreText.text = "HIGHSCORE: " + highScore;

        switch (numberOfLives)
        {
            case 0:
                this.GetComponent<keyboardManager>().mainMenu.SetActive(true);
                Time.timeScale = 0.0f;
                this.GetComponent<keyboardManager>().paused = true;
                Cursor.visible = true;
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                heart4.SetActive(false);
                heart5.SetActive(false);
                Time.timeScale = 1.0f;
                break;
            case 1:
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);
                heart4.SetActive(false);
                heart5.SetActive(false);
                break;
            case 2:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);
                heart4.SetActive(false);
                heart5.SetActive(false);
                break;
            case 3:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                heart4.SetActive(false);
                heart5.SetActive(false);
                break;
            case 4:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                heart4.SetActive(true);
                heart5.SetActive(false);
                break;
            case 5:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                heart4.SetActive(true);
                heart5.SetActive(true);
                break;
            default:
                break;
        }
	}
}
