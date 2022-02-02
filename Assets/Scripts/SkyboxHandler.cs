using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxHandler : MonoBehaviour
{
    public Material[] SkyBoxArray;


    void Start()
    {

    }


    void Update()
    {
        skyBoxHandler();

    }
    void skyBoxHandler()
    {
        //    int skyBoxCount = 0;
        //    if (Input.GetKey("UpArrow"))
        //    {
        //        RenderSettings.skybox = SkyBoxArray[skyBoxCount];
        //        skyBoxCount += 1;
        //        if (skyBoxCount >= 11)
        //        {
        //            skyBoxCount = 0;
        //        }
        //    }


        if (Input.GetButtonDown("1"))
        {
            RenderSettings.skybox = SkyBoxArray[0];
        }
        else if (Input.GetButtonDown("2"))
        {
            RenderSettings.skybox = SkyBoxArray[1];
        }
        else if (Input.GetButtonDown("3"))
        {
            RenderSettings.skybox = SkyBoxArray[2];
        }
        else if (Input.GetButtonDown("4"))
        {
            RenderSettings.skybox = SkyBoxArray[3];
        }
        else if (Input.GetButtonDown("5"))
        {
            RenderSettings.skybox = SkyBoxArray[4];
        }
        else if (Input.GetButtonDown("6"))
        {
            RenderSettings.skybox = SkyBoxArray[5];
        }
        else if (Input.GetButtonDown("7"))
        {
            RenderSettings.skybox = SkyBoxArray[6];
        }
        else if (Input.GetButtonDown("8"))
        {
            RenderSettings.skybox = SkyBoxArray[7];
        }
        else if (Input.GetButtonDown("9"))
        {
            RenderSettings.skybox = SkyBoxArray[8];
        }
        else if (Input.GetButtonDown("0"))
        {
            RenderSettings.skybox = SkyBoxArray[9];
        }


    }
}
