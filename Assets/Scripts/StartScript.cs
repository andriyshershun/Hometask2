using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {
    Button button;
    public Button buttonExit;
    private float nextLogoPos = -130;
    public Image imageLogoUnity;
    private readonly float SPEED = 100f;
    private bool isStarted = false;
   

    public float LogoPosition
    {
        get
        {
            return imageLogoUnity.transform.position.x;
        }

        set
        {
            imageLogoUnity.transform.position = new Vector3(value,
                imageLogoUnity.transform.position.y, imageLogoUnity.transform.position.z);
        }
    }

    // Use this for initialization
    void Start ()
    {
        button = gameObject.GetComponent<Button>();
        nextLogoPos = imageLogoUnity.transform.position.x;

        button.onClick.AddListener(delegate () { StartGame(); });
    }

    private void StartGame()
    {
        isStarted           = !isStarted;
        if (!isStarted)     button.GetComponentInChildren<Text>().text = "Start game";
        else                button.GetComponentInChildren<Text>().text = "Stop game";
        Debug.Log("OnCLick");
    }


    // Update is called once per frame
    void Update ()
    {
        if (isStarted && Time.time > nextLogoPos)
        {
            moveLogoGame();
        }
    }

    private void moveLogoGame()
    {
        var newLogoPosition = LogoPosition;
        if (LogoPosition > 800)
        {
            newLogoPosition = -103;
            nextLogoPos = 0;
        }
        LogoPosition = newLogoPosition + SPEED * Time.deltaTime;
        //imageLogoUnity.transform.position = new Vector3(,
          //  imageLogoUnity.transform.position.y, imageLogoUnity.transform.position.z);
    }
}
