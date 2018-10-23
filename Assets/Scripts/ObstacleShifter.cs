using UnityEngine;
using System.Collections;

public class ObstacleShifter : MonoBehaviour {

    public GameObject[] Shapes1;
    public GameObject[] Shapes2;
    public GameObject[] Shapes3;

    public GameObject[] Particles1;
    public GameObject[] Particles2;
    public GameObject[] Particles3;

    void Start()
    {
        foreach(GameObject shape in Shapes1)
            shape.SetActive(false);

        foreach (GameObject shape in Shapes2)
            shape.SetActive(false);

        foreach (GameObject shape in Shapes3)
            shape.SetActive(false);

        foreach (GameObject particle in Particles1)
            particle.SetActive(false);

        foreach (GameObject particle in Particles2)
            particle.SetActive(false);

        foreach (GameObject particle in Particles3)
            particle.SetActive(false);

        
        float posVertical = 0.0f;
        float posHorizontal = 0.0f;

        int random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                posVertical = -5.0f;
                posHorizontal = 0.0f;
                break;
            case 1:
                posVertical = 0.0f;
                posHorizontal = -8.0f;
                break;
            case 2:
                posVertical = 5.0f;
                posHorizontal = 0.0f;
                break;
            case 3:
                posVertical = 0.0f;
                posHorizontal = 8.0f;
                break;
        }

        random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                Shapes1[0].SetActive(true);
                Shapes1[0].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles1[0].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            case 1:
                Shapes1[1].SetActive(true);
                Shapes1[1].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles1[1].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            case 2:
                Shapes1[2].SetActive(true);
                Shapes1[2].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles1[2].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            case 3:
                Shapes1[3].SetActive(true);
                Shapes1[3].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles1[3].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            default:
                break;
        }

        random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                posVertical = -5.0f;
                posHorizontal = 0.0f;
                break;
            case 1:
                posVertical = 0.0f;
                posHorizontal = -8.0f;
                break;
            case 2:
                posVertical = 5.0f;
                posHorizontal = 0.0f;
                break;
            case 3:
                posVertical = 0.0f;
                posHorizontal = 8.0f;
                break;
        }

        random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                Shapes2[0].SetActive(true);
                Shapes2[0].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles2[0].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            case 1:
                Shapes2[1].SetActive(true);
                Shapes2[1].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles2[1].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            case 2:
                Shapes2[2].SetActive(true);
                Shapes2[2].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles2[2].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            case 3:
                Shapes2[3].SetActive(true);
                Shapes2[3].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles2[3].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            default:
                break;
        }

        random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                posVertical = -5.0f;
                posHorizontal = 0.0f;
                break;
            case 1:
                posVertical = 0.0f;
                posHorizontal = -8.0f;
                break;
            case 2:
                posVertical = 5.0f;
                posHorizontal = 0.0f;
                break;
            case 3:
                posVertical = 0.0f;
                posHorizontal = 8.0f;
                break;
        }

        random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                Shapes3[0].SetActive(true);
                Shapes3[0].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles3[0].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            case 1:
                Shapes3[1].SetActive(true);
                Shapes3[1].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles3[1].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            case 2:
                Shapes3[2].SetActive(true);
                Shapes3[2].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles3[2].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            case 3:
                Shapes3[3].SetActive(true);
                Shapes3[3].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                Particles3[3].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
                break;
            default:
                break;
        }
    }
	
}
