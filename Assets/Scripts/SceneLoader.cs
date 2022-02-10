using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject pauseMenuUI;
    CoinCollection coin;
    bool IsPaused;
    private GameObject InitialUI;
    void Start()
    {
        IsPaused = false;
        InitialUI = coin.GetInitialUI() as GameObject;
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
        //InitialUI.SetActive(true);
        Time.timeScale = 1f;
        IsPaused = false;
        
        pauseMenuUI.SetActive(false);
    }

    public void Paused()
    {
        //InitialUI.SetActive(false);
        IsPaused = true;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
    }

    private void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void MainMenuUI()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
