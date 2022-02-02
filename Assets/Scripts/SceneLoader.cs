using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public GameObject MainMenuUI;
    public GameObject ShowUI;
    public GameObject HideUI;

    bool IsPaused;

    void Start()
    {
        IsPaused = false;
        MainMenuUI.SetActive(false);
        pauseMenuUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (IsPaused == false)
            {
                Paused();
            }
            else
            {
                Resume();
            }
                

        }
        
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        IsPaused = false;
        
        pauseMenuUI.SetActive(false);
    }

    public void Paused()
    {
        IsPaused = true;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void ShowMainMenu()
    {
        ShowUI.SetActive(false);
        MainMenuUI.SetActive(true);
        HideUI.SetActive(true);
    }
    public void HideMenuUI()
    {
        HideUI.SetActive(false);
        MainMenuUI.SetActive(false);
        ShowUI.SetActive(true);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
