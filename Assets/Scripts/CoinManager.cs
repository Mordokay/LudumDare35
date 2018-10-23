using UnityEngine;
using System.Collections;

public class CoinManager : MonoBehaviour {


    public GameObject[] Coins;
    Vector3 firstCoinPos;
    int randomIncVertical;
    int randomIncHorizontal;

    void Start () {
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
        
        for (int i = 0; i < Coins.Length / 2; i++) {
            int secondRandom = Random.Range(0, 9);
            if (secondRandom < 7)
                Coins[i].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
            else
                Coins[i].SetActive(false);
            }

        random = Random.Range(0, 4);
        posVertical = 0.0f;
        posHorizontal = 0.0f;

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
        
        for (int i = Coins.Length / 2; i < Coins.Length; i++) {
            int secondRandom = Random.Range(0, 9);
            if (secondRandom< 7)
                Coins[i].transform.Translate(new Vector3(posHorizontal, posVertical, 0));
            else
                Coins[i].SetActive(false);
        }
    }
}
