using UnityEngine;
using System.Collections;

public class HeartsManager : MonoBehaviour {

    public GameObject[] hearts;

	// Use this for initialization
	void Start () {

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

        int randomHearts = Random.Range(0, 10);

        if (randomHearts == 4)
        {
            int pos = Random.Range(0, 2);
            hearts[pos].SetActive(true);
            hearts[pos].transform.position  = new Vector3(posHorizontal, posVertical, hearts[pos].transform.position.z);
        }
            
    }
}
