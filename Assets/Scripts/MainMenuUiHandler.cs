using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUiHandler : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject ShowUI;
    public GameObject HideUI;

    void Start()
    {
        MainMenuUI.SetActive(false);
    }
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
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
