using UnityEngine;
using System.Collections;

public class SpecialShapeController : MonoBehaviour {

    float specialShapeRotationSpeed;
    gameController gameManager;

    public bool isTriangle;
    public bool isSquare;
    public bool isStar;
    public bool isCircle;
    public GameObject TriangleParticle;
    public GameObject SquareParticle;
    public GameObject StarParticle;
    public GameObject CircleParticle;

    GameObject DeathFlash;

    // Use this for initialization
    void Start()
    {
        specialShapeRotationSpeed = 250.0f;
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<gameController>();
        DeathFlash = Camera.main.transform.Find("DeathFlash").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * specialShapeRotationSpeed, 0));
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            if (other.name.Equals("Triangle") && isTriangle)
            {
                TriangleParticle.SetActive(true);
                Destroy(this.gameObject);
                gameManager.numberOfPoints += 10;
                DeathFlash.GetComponent<AudioSource>().Play();
            }
            else if (other.name.Equals("Circle") && isCircle)
            {
                CircleParticle.SetActive(true);
                Destroy(this.gameObject);
                gameManager.numberOfPoints += 10;
                DeathFlash.GetComponent<AudioSource>().Play();
            }
            else if (other.name.Equals("Star") && isStar)
            {
                StarParticle.SetActive(true);
                Destroy(this.gameObject);
                gameManager.numberOfPoints += 10;
                DeathFlash.GetComponent<AudioSource>().Play();
            }
            else if (other.name.Equals("Square") && isSquare)
            {
                SquareParticle.SetActive(true);
                Destroy(this.gameObject);
                gameManager.numberOfPoints += 10;
                DeathFlash.GetComponent<AudioSource>().Play();
            }
            else {
                this.transform.parent.GetComponent<AudioSource>().Play();
                gameManager.GetComponent<gameController>().numberOfLives -= 1;
            }
        }
    }
}
