using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using UnityEngine.UI;
using System.Linq;
using System.IO;
using System;

public class SaveManager : MonoBehaviour
{
    [SerializeField]
    private Camera camera1;
    private List<Image> madingImage;

    [SerializeField]
    private List<Button> saveButtons;

    [SerializeField]
    private Image imagesSample;

    private int value = 0;
    public string folderName = "";

    void Start()
    {
        
    }

    public void Levale(int value1)
    {
        name = DateTime.Now.ToString("yyyy-MM-dd-tt-mm-ss");
        value = value1;
        StartCoroutine("ScreenShot");
    }

    public void ScreenShotClick()
    {
        RenderTexture renderTexture = camera1.targetTexture;
        madingImage.Add(Instantiate(imagesSample));

    }



}
