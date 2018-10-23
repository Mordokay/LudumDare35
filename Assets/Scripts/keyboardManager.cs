using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class keyboardManager : MonoBehaviour {

    public bool paused;

    public GameObject currentShape;
    public GameObject newShape;
    public GameObject Triangle;
    public GameObject Square;
    public GameObject Star;
    public GameObject Circle;

    Vector3 originalScaleTriangle;
    Vector3 originalScaleSquare;
    Vector3 originalScaleStar;
    Vector3 originalScaleCircle;

    public GameObject toggleMute;
    public GameObject toggleFastMode;
    public GameObject toggleHardcoreMode;

    Vector3 originalScale;
    Vector3 destinationScale;

    public float scaletransitionTime;
    public float scaleTransitionDuration;

    public float lastVolume;
    public float zoomOut;
    public bool isScalingUp;
    public bool isScalingDown;
    public bool transitionLock;

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject helpMenu;
    public Button continueButton;
    public Slider volumeSlider;

    public GameObject controlsText;
    public GameObject pipesInfo;
    public GameObject itemsInfo;
    public GameObject shapesInfo;

    Vector3 savedShiftingPos;

    // Use this for initialization
    void Start () {
        paused = false;
        transitionLock = false;
        scaletransitionTime = 0.05f;

        originalScaleTriangle = Triangle.transform.localScale;
        originalScaleSquare = Square.transform.localScale;
        originalScaleStar = Star.transform.localScale;
        originalScaleCircle = Circle.transform.localScale;

        volumeSlider.value = 0.5f;
        AudioListener.volume = volumeSlider.value;

        if (Time.time == 0) { 
            Time.timeScale = 0.0f;
            paused = true;
            Cursor.visible = true;
            //showMenu();
            showHelpMenu();
            continueButton.interactable = false;
        }
        lastVolume = 50.0f;
        if (PlayerPrefs.GetInt("fastMode") == 1)
        {
            toggleFastMode.GetComponent<Toggle>().isOn = true;
        }
    }


    void transitionNewCursor() {
        if (transitionLock) {
            if (isScalingDown)
            {
                if (scaleTransitionDuration < (scaletransitionTime / 2))
                {
                    currentShape.transform.localScale = originalScale * (((scaletransitionTime / 2) - scaleTransitionDuration) / (scaletransitionTime / 2));
                    currentShape.transform.position = savedShiftingPos;
                    scaleTransitionDuration += Time.deltaTime;
                }
                else
                {
                    isScalingDown = false;
                    isScalingUp = true;
                    if(currentShape.name.Equals("Triangle"))
                        currentShape.transform.localScale = originalScaleTriangle;
                    else if (currentShape.name.Equals("Star"))
                        currentShape.transform.localScale = originalScaleStar;
                    else if (currentShape.name.Equals("Circle"))
                        currentShape.transform.localScale = originalScaleCircle;
                    else if (currentShape.name.Equals("Square"))
                        currentShape.transform.localScale = originalScaleSquare;

                    currentShape.SetActive(false);
                    currentShape = newShape;
                    currentShape.SetActive(true);
                }
            }
            else if (isScalingUp)
            {
                if (scaleTransitionDuration < scaletransitionTime)
                {
                    currentShape.transform.localScale = destinationScale * ((scaleTransitionDuration - (scaletransitionTime / 2)) / (scaletransitionTime / 2));
                    currentShape.transform.position = savedShiftingPos;
                    scaleTransitionDuration += Time.deltaTime;
                }
                else {
                    isScalingUp = false;
                    transitionLock = false;
                    scaleTransitionDuration = 0.0f;
                    if (currentShape.name.Equals("Triangle"))
                        currentShape.transform.localScale = originalScaleTriangle;
                    else if (currentShape.name.Equals("Star"))
                        currentShape.transform.localScale = originalScaleStar;
                    else if (currentShape.name.Equals("Circle"))
                        currentShape.transform.localScale = originalScaleCircle;
                    else if (currentShape.name.Equals("Square"))
                        currentShape.transform.localScale = originalScaleSquare;
                }
            }
        }
    }

    public void resetHighScore()
    {
        PlayerPrefs.DeleteAll();
        this.GetComponent<gameController>().highScore = 0;
    }

    public void showMenu() {
        mainMenu.SetActive(true);
        continueButton.interactable = true;
        optionsMenu.SetActive(false);
        helpMenu.SetActive(false);
    }

    public void showHelpMenu()
    {
        mainMenu.SetActive(true);
        continueButton.interactable = true;
        optionsMenu.SetActive(false);
        helpMenu.SetActive(true);
        showInstructions();
    }

    public void hideMenu() {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        helpMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

    public void showInstructions()
    {
        mainMenu.SetActive(false);
        helpMenu.SetActive(true);
        showControlsInfo();
    }

    public void OptionsMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void returnToMainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        helpMenu.SetActive(false);
    }

    public void returnToGame()
    {
        Time.timeScale = 1.0f;
        paused = false;
        Cursor.visible = false;
        hideMenu();
    }

    public void CheckMute()
    {
        if (toggleMute.GetComponent<Toggle>().isOn) { 
            lastVolume = volumeSlider.value;
            volumeSlider.value = 0;
        }
        else {
            volumeSlider.value = lastVolume;
        }
    }

    public void CheckSoundVolume()
    {
        AudioListener.volume = volumeSlider.value;
        if (volumeSlider.value == 0)
        {
            toggleMute.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            toggleMute.GetComponent<Toggle>().isOn = false;
        }
    }

    public void showControlsInfo()
    {
        controlsText.SetActive(true);
        pipesInfo.SetActive(false);
        itemsInfo.SetActive(false);
        shapesInfo.SetActive(false);
    }
    public void showPipesInfo()
    {
        controlsText.SetActive(false);
        pipesInfo.SetActive(true);
        itemsInfo.SetActive(false);
        shapesInfo.SetActive(false);
    }
    public void showItemsInfo()
    {
        controlsText.SetActive(false);
        pipesInfo.SetActive(false);
        itemsInfo.SetActive(true);
        shapesInfo.SetActive(false);
    }
    public void showShapesInfo()
    {
        controlsText.SetActive(false);
        pipesInfo.SetActive(false);
        itemsInfo.SetActive(false);
        shapesInfo.SetActive(true);
    }

    // Update is called once per frame
    void Update() {

        if (!toggleMute.GetComponent<Toggle>().isOn) {
            AudioListener.pause = false;
        }
        else if (toggleMute.GetComponent<Toggle>().isOn)
        {
            AudioListener.pause = true;
        }
        if(toggleFastMode.GetComponent<Toggle>().isOn)
        {
            PlayerPrefs.SetInt("fastMode", 1);
        }
        else
        {
            PlayerPrefs.SetInt("fastMode", 0);
        }

        transitionNewCursor();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Time.timeScale = 1.0f;
                paused = false;
                Cursor.visible = false;
                hideMenu();
            }
            else
            {
                Time.timeScale = 0.0f;
                paused = true;
                Cursor.visible = true;
                continueButton.interactable = true;
                showMenu();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!currentShape.Equals(Circle) && !transitionLock) {
                savedShiftingPos = currentShape.transform.position;
                newShape = Circle;
                originalScale = currentShape.transform.localScale;
                destinationScale = Circle.transform.localScale;
                isScalingDown = true;
                transitionLock = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.W) && !transitionLock)
        {
            if (!currentShape.Equals(Square) && !transitionLock)
            {
                savedShiftingPos = currentShape.transform.position;
                newShape = Square;
                originalScale = currentShape.transform.localScale;
                destinationScale = Square.transform.localScale;
                isScalingDown = true;
                transitionLock = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.E) && !transitionLock)
        {
            if (!currentShape.Equals(Star) && !transitionLock)
            {
                savedShiftingPos = currentShape.transform.position;
                newShape = Star;
                originalScale = currentShape.transform.localScale;
                destinationScale = Star.transform.localScale;
                isScalingDown = true;
                transitionLock = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.R) && !transitionLock)
        {
            if (!currentShape.Equals(Triangle) && !transitionLock)
            {
                savedShiftingPos = currentShape.transform.position;
                newShape = Triangle;
                originalScale = currentShape.transform.localScale;
                destinationScale = Triangle.transform.localScale;
                isScalingDown = true;
                transitionLock = true;
            }
        }
    }
}
