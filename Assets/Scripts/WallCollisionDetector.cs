using UnityEngine;
using System.Collections;

public class WallCollisionDetector : MonoBehaviour {

    GameObject gameManager;
    GameObject crashSound;
    HoleShifter holeShifter;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        crashSound = Camera.main.transform.Find("CrashSound").gameObject;
        holeShifter = this.transform.parent.GetComponent<HoleShifter>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !holeShifter.crashed)
        {
            crashSound.GetComponent<AudioSource>().Play();
            gameManager.GetComponent<gameController>().numberOfLives -= 1;
            holeShifter.crashed = true;
        }
    }
}
