using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtonScript : MonoBehaviour {
    public GameObject panelMenu;

    private Button buttonExit;
    private float nextXTime;
    private float INTERVAL = 0.5f;
    private bool isExit = false;


    // Use this for initialization
    void Start () {
        buttonExit = gameObject.GetComponent<Button>();
        buttonExit.onClick.AddListener (delegate() { exitGame(); });
	}

    private void exitGame()
    {
        isExit = !isExit;
    }

    // Update is called once per frame
    void Update () {
        if (isExit && Time.time >= nextXTime && panelMenu.transform.rotation.y > -0.70)
        {
            nextXTime -= INTERVAL * Time.deltaTime;
            panelMenu.transform.Rotate(new Vector3(0, nextXTime, 0));
            Debug.Log(panelMenu.transform.rotation.y);
        }
	}
}
