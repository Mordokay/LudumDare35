using UnityEngine;
using System.Collections;

public class HoleShifter : MonoBehaviour {

    public GameObject hole;
    public GameObject colliderHole;
    public GameObject[] wallColliders;
    public bool crashed;

    void Start(){
        crashed = false;
    }

    public void shift()
    {
        int random = Random.Range(0, 4);
        float posVertical = 0.0f;
        float posHorizontal = 0.0f;

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

        hole.transform.position = new Vector3(posHorizontal, posVertical, hole.transform.position.z);
        colliderHole.transform.position = new Vector3(posHorizontal, posVertical, hole.transform.position.z);
        foreach (GameObject wallCollider in wallColliders)
        {
            wallCollider.transform.position = new Vector3(wallCollider.transform.position.x + posHorizontal, wallCollider.transform.position.y + posVertical, wallCollider.transform.position.z);
        }
    }
}
