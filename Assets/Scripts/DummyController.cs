using UnityEngine;
using System.Collections;

public class DummyController : MonoBehaviour {

    gameController gameManager;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<gameController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crusher")
        {
            gameManager.GetComponent<ObstacleSpawner>().instanciateObstacle();
            Destroy(this.transform.parent.gameObject);
        }
    }
}
