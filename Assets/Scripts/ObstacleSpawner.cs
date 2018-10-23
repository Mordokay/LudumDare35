using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour {

    public int numObstacles;
    public float lastZAxisObstacle;

    // Use this for initialization
    void Start () {
        numObstacles = 6;
        lastZAxisObstacle = numObstacles * 40.0f;

        Instantiate(Resources.Load("EmptyObstacle"), new Vector3(0, 0, -40.0f), Quaternion.identity);
        Instantiate(Resources.Load("EmptyObstacle"), new Vector3(0, 0, 0.0f), Quaternion.identity);

        for (int i = 1; i < numObstacles; i++)
        {
            int random = Random.Range(0, 8);
            switch (random)
            {
                case 0:
                    Object shapeObstacle1 = Instantiate(Resources.Load("CircleObstacle"), new Vector3(0, 0, i * 40.0f), Quaternion.identity);
                    GameObject shapeObstacleAux1 = (GameObject)shapeObstacle1;
                    shapeObstacleAux1.GetComponent<HoleShifter>().shift();
                    break;
                case 1:
                    Object shapeObstacle2 = Instantiate(Resources.Load("SquareObstacle"), new Vector3(0, 0, i * 40.0f), Quaternion.identity);
                    GameObject shapeObstacleAux2 = (GameObject)shapeObstacle2;
                    shapeObstacleAux2.GetComponent<HoleShifter>().shift();
                    break;
                case 2:
                    Object shapeObstacle3 = Instantiate(Resources.Load("StarObstacle"), new Vector3(0, 0, i * 40.0f), Quaternion.identity);
                     GameObject shapeObstacleAux3 = (GameObject)shapeObstacle3;
                    shapeObstacleAux3.GetComponent<HoleShifter>().shift();
                    break;
                case 3:
                    object shapeObstacle4 = Instantiate(Resources.Load("TriangleObstacle"), new Vector3(0, 0, i * 40.0f), Quaternion.identity);
                     GameObject shapeObstacleAux4 = (GameObject)shapeObstacle4;
                    shapeObstacleAux4.GetComponent<HoleShifter>().shift();
                    break;
                case 4:
                    Instantiate(Resources.Load("Obstacle"), new Vector3(0, 0, i * 40.0f), Quaternion.identity);
                    break;
                case 5:
                    Instantiate(Resources.Load("Obstacle"), new Vector3(0, 0, i * 40.0f), Quaternion.identity);
                    break;
                default:
                    Instantiate(Resources.Load("Coin Spawner"), new Vector3(0, 0, i * 40.0f), Quaternion.identity);
                    break;
            }
        }
    }

    public void instanciateObstacle()
    {
        int random = Random.Range(0, 8);
        switch (random)
        {
            case 0:
                Object shapeObstacle1 = Instantiate(Resources.Load("CircleObstacle"), new Vector3(0, 0, lastZAxisObstacle), Quaternion.identity);
                GameObject shapeObstacleAux1 = (GameObject)shapeObstacle1;
                shapeObstacleAux1.GetComponent<HoleShifter>().shift();
                break;
            case 1:
                Object shapeObstacle2 = Instantiate(Resources.Load("SquareObstacle"), new Vector3(0, 0, lastZAxisObstacle), Quaternion.identity);
                GameObject shapeObstacleAux2 = (GameObject)shapeObstacle2;
                shapeObstacleAux2.GetComponent<HoleShifter>().shift();
                break;
            case 2:
                Object shapeObstacle3 = Instantiate(Resources.Load("StarObstacle"), new Vector3(0, 0, lastZAxisObstacle), Quaternion.identity);
                GameObject shapeObstacleAux3 = (GameObject)shapeObstacle3;
                shapeObstacleAux3.GetComponent<HoleShifter>().shift();
                break;
            case 3:
                Object shapeObstacle4 = Instantiate(Resources.Load("TriangleObstacle"), new Vector3(0, 0, lastZAxisObstacle), Quaternion.identity);
                GameObject shapeObstacleAux4 = (GameObject)shapeObstacle4;
                shapeObstacleAux4.GetComponent<HoleShifter>().shift();
                break;
            case 4:
                Instantiate(Resources.Load("Obstacle"), new Vector3(0, 0, lastZAxisObstacle), Quaternion.identity);
                break;
            case 5:
                Instantiate(Resources.Load("Obstacle"), new Vector3(0, 0, lastZAxisObstacle), Quaternion.identity);
                break;
            default:
                Instantiate(Resources.Load("Coin Spawner"), new Vector3(0, 0, lastZAxisObstacle), Quaternion.identity);
                break;
        }
        lastZAxisObstacle += 40.0f;
    }
}
