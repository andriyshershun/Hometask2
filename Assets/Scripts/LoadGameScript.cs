using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameScript : MonoBehaviour {
    public GameObject panel;
    
    public Text textMainMenu;

    private RectTransform panelMenu;
    private const float INTERVAL = 0.5f;
    private float nextXTime = 0;
    private float nextYTime = 0;
    private float nextAlfaTime = 0;
    private float r;
    private float g;
    private float b;

    // Update is called once per frame
    void Start ()
    {
        panelMenu = gameObject.GetComponent<RectTransform>();
        r = textMainMenu.color.r;
        g = textMainMenu.color.g;
        b = textMainMenu.color.b;
    }
    void FixedUpdate()
    {
        if (Time.time > nextAlfaTime)
        {
            nextAlfaTime += INTERVAL * Time.deltaTime;
            textMainMenu.color = new Color(r,g,b,nextAlfaTime);
        }
        if (Time.time >= nextXTime && panelMenu.transform.localScale.x < 1)
        {
            nextXTime += INTERVAL * Time.deltaTime;
            panelMenu.transform.localScale = new Vector3(nextXTime, 0.01f, 1);
        }
        
        else if (Time.time >= nextYTime && panelMenu.transform.localScale.y < 1)
        {
            nextYTime += INTERVAL * Time.deltaTime;
            panelMenu.transform.localScale = new Vector3( 1, nextYTime, 1);
        }

    }

    void Update()
    {
       
    }

}
