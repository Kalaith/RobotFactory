using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    GameObject canvas;
    GameObject dialog;
    GameObject gameText;
    public Sprite dialogBackground;

    Robot[] robots;

    public GameObject Canvas
    {
        get
        {
            return canvas;
        }

        set
        {
            canvas = value;
        }
    }

    // Use this for initialization
    void Start () {
        canvas = new GameObject();
        dialog = new GameObject();

        dialog.AddComponent<RectTransform>();
        dialog.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, 350);

        dialog.AddComponent<Image>();
        dialog.GetComponent<Image>().sprite = dialogBackground;

        Color c;
        ColorUtility.TryParseHtmlString("#FFFFFF77", out c);
        dialog.GetComponent<Image>().color = c;

        dialog.name = "rf_Dialog";
        dialog.layer = 5;

        dialog.transform.SetParent(canvas.transform);

        dialog.transform.position = new Vector3(0, -175, 0);
        
        canvas.AddComponent<Canvas>();
        canvas.AddComponent<GraphicRaycaster>();
        canvas.AddComponent<CanvasScaler>();

        canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;

        canvas.name = "rf_Canvas";
        canvas.layer = 5;

        canvas.SetActive(false);

        // temp code to display robots in ui.
        for (int i = 0; i == 3; i++)
        {
            robots[0] = new Robot(0, 0, "Robot" + i);
        }

    }

    public void setText(string talk)
    {
        if (gameText == null)
        {
            gameText = new GameObject();
            gameText.AddComponent<Text>();
            //gameText.AddComponent<RectTransform>();
            gameText.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 100);
            gameText.GetComponent<RectTransform>().transform.position = new Vector3(0, 0, 0);
            gameText.transform.SetParent(dialog.transform);
            gameText.GetComponent<Text>().font = Font.CreateDynamicFontFromOSFont("Arial", 12);
            gameText.transform.position = new Vector3(300, 150, 0);
        }
        gameText.GetComponent<Text>().text = talk;

    }

    // Update is called once per frame
    void Update () {

       
    }
}
