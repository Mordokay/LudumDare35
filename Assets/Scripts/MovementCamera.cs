using UnityEngine;
using System.Collections;

public class MovementCamera : MonoBehaviour {

    public float cameraSpeed;
    public float maxSpeed;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("fastMode") == 1)
        {
            cameraSpeed = 20.0f;
            maxSpeed = 40.0f;
        }
        else
        {
            cameraSpeed = 10.0f;
            maxSpeed = 30.0f;
        }
        float newSpeed = cameraSpeed + (Time.timeSinceLevelLoad / 30);
        newSpeed = Mathf.Clamp(newSpeed, cameraSpeed, maxSpeed);
        this.transform.Translate(Vector3.forward * Time.deltaTime * newSpeed);

	}
}
