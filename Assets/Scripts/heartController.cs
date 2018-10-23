using UnityEngine;
using System.Collections;

public class heartController : MonoBehaviour {

    float specialShapeRotationSpeed;
    gameController gameManager;

    public GameObject heartSound;


    // Use this for initialization
    void Start () {
        specialShapeRotationSpeed = 360.0f;
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<gameController>();
    }
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * specialShapeRotationSpeed, 0));
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            if (gameManager.GetComponent<gameController>().numberOfLives < 5) {
                gameManager.GetComponent<gameController>().numberOfLives += 1;
            }
            heartSound.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
        }
    }

}
