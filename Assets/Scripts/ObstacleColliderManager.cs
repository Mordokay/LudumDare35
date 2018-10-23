using UnityEngine;
using System.Collections;

public class ObstacleColliderManager : MonoBehaviour
{
    public Material lockMat;
    public Material normalMat;
    GameObject gameManager;
    public bool isDummy;
    public GameObject hole;

    public bool isCircleObstacle;
    public bool isStarObstacle;
    public bool isSquareObstacle;
    public bool isTriangleObstacle;

    GameObject crashSound;

    GameObject playerTouching;

    public bool touching;
    // Use this for initialization
    void Start()
    {
        touching = false;
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        crashSound = Camera.main.transform.Find("CrashSound").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (touching && !this.transform.parent.GetComponent<HoleShifter>().crashed) {
            if (Input.GetKeyDown(KeyCode.Space) && !isDummy)
            {
                if (playerTouching.gameObject.name.Equals("Triangle") && isTriangleObstacle)
                {
                    hole.GetComponent<Renderer>().material = lockMat;
                    this.GetComponent<AudioSource>().Play();
                    gameManager.GetComponent<gameController>().numberOfPoints += 20;
                    this.transform.parent.GetComponent<HoleShifter>().crashed = true;
                }
                else if (playerTouching.gameObject.name.Equals("Square") && isSquareObstacle)
                {
                    hole.GetComponent<Renderer>().material = lockMat;
                    this.GetComponent<AudioSource>().Play();
                    gameManager.GetComponent<gameController>().numberOfPoints += 20;
                    this.transform.parent.GetComponent<HoleShifter>().crashed = true;
                }
                else if (playerTouching.gameObject.name.Equals("Star") && isStarObstacle)
                {
                    hole.GetComponent<Renderer>().material = lockMat;
                    this.GetComponent<AudioSource>().Play();
                    gameManager.GetComponent<gameController>().numberOfPoints += 20;
                    this.transform.parent.GetComponent<HoleShifter>().crashed = true;
                }
                else if (playerTouching.gameObject.name.Equals("Circle") && isCircleObstacle)
                {
                    hole.GetComponent<Renderer>().material = lockMat;
                    this.GetComponent<AudioSource>().Play();
                    gameManager.GetComponent<gameController>().numberOfPoints += 20;
                    this.transform.parent.GetComponent<HoleShifter>().crashed = true;
                }
                else
                {
                    crashSound.GetComponent<AudioSource>().Play();
                    gameManager.GetComponent<gameController>().numberOfLives -= 1;
                    this.transform.parent.GetComponent<HoleShifter>().crashed = true;
                }
            }
            else if (!isDummy)
            {
                if (playerTouching.gameObject.name.Equals("Triangle") && !isTriangleObstacle)
                {
                    crashSound.GetComponent<AudioSource>().Play();
                    gameManager.GetComponent<gameController>().numberOfLives -= 1;
                    this.transform.parent.GetComponent<HoleShifter>().crashed = true;
                }
                else if (playerTouching.gameObject.name.Equals("Square") && !isSquareObstacle)
                {
                    crashSound.GetComponent<AudioSource>().Play();
                    gameManager.GetComponent<gameController>().numberOfLives -= 1;
                    this.transform.parent.GetComponent<HoleShifter>().crashed = true;
                }
                else if (playerTouching.gameObject.name.Equals("Star") && !isStarObstacle)
                {
                    crashSound.GetComponent<AudioSource>().Play();
                    gameManager.GetComponent<gameController>().numberOfLives -= 1;
                    this.transform.parent.GetComponent<HoleShifter>().crashed = true;
                }
                else if (playerTouching.gameObject.name.Equals("Circle") && !isCircleObstacle)
                {
                    crashSound.GetComponent<AudioSource>().Play();
                    gameManager.GetComponent<gameController>().numberOfLives -= 1;
                    this.transform.parent.GetComponent<HoleShifter>().crashed = true;
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTouching = other.gameObject;
            touching = true;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            touching = false;
        }
    }
}
