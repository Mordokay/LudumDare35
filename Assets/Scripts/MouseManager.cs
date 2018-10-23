using UnityEngine;
using System.Collections;

public class MouseManager : MonoBehaviour {

    public GameObject Circle;
    public GameObject Triangle;
    public GameObject Square;
    public GameObject Star;

    GameObject myCursor;

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
        this.GetComponent<keyboardManager>().currentShape = Circle;
        this.GetComponent<keyboardManager>().currentShape.SetActive(true);
        myCursor = this.GetComponent<keyboardManager>().currentShape;
    }
	
	// Update is called once per frame
	void Update () {
        myCursor = this.GetComponent<keyboardManager>().currentShape;
        if (!this.GetComponent<keyboardManager>().paused) {
            if (Input.GetKeyDown(KeyCode.LeftArrow)){
                myCursor.transform.position = new Vector3(-8.0f, 0.0f, Camera.main.transform.position.z + 10.0f);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                myCursor.transform.position = new Vector3(8.0f, 0.0f, Camera.main.transform.position.z + 10.0f);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                myCursor.transform.position = new Vector3(0.0f, 5.0f, Camera.main.transform.position.z + 10.0f);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                myCursor.transform.position = new Vector3(0.0f, -5.0f, Camera.main.transform.position.z + 10.0f);
            }
            myCursor.transform.position = new Vector3(myCursor.transform.position.x, myCursor.transform.position.y, Camera.main.transform.position.z + 10.0f);
            //Vector3 myCursorPosition = Input.mousePosition;
            //myCursorPosition = new Vector3(Mathf.Clamp(myCursorPosition.x, Screen.width / 9, Screen.width - (Screen.width / 9)),
            //                                    Mathf.Clamp(myCursorPosition.y, Screen.height / 9, Screen.height - (Screen.height / 9)), myCursorPosition.z);
            //myCursorPosition.z = 10.0f;
            //myCursorPosition = Camera.main.ScreenToWorldPoint(myCursorPosition);
            //myCursor.transform.position = new Vector3(myCursorPosition.x, myCursorPosition.y, Camera.main.transform.position.z + 10.0f);
        }
    }
}
