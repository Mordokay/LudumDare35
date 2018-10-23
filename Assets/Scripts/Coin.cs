using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    float coinRotationSpeed;
    gameController gameManager;

	// Use this for initialization
	void Start () {
        coinRotationSpeed = 300.0f;
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<gameController>();
    }
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * coinRotationSpeed, 0));
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Camera.main.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
            gameManager.numberOfPoints += 1;
        }
    }
}
