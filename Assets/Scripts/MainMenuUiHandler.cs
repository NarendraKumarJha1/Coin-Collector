using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuUiHandler : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject ShowUI;
    public GameObject HideUI;
    public AudioClip ClickSFX;
    void Start()
    {
        
        MainMenuUI.SetActive(false);
    }
    void Update()
    {
        
    }

    public void Play()
    {
        AudioSource.PlayClipAtPoint(ClickSFX, transform.position);
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        AudioSource.PlayClipAtPoint(ClickSFX, transform.position);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void ShowMainMenu()
    {
        AudioSource.PlayClipAtPoint(ClickSFX, transform.position);
        ShowUI.SetActive(false);
        MainMenuUI.SetActive(true);
        HideUI.SetActive(true);
    }
    public void HideMenuUI()
    {
        AudioSource.PlayClipAtPoint(ClickSFX,transform.position);   
        HideUI.SetActive(false);
        MainMenuUI.SetActive(false);
        ShowUI.SetActive(true);
    }
    public void OnApplicationQuit()
    {
        AudioSource.PlayClipAtPoint(ClickSFX, transform.position);
        Application.Quit();
    }
    public void SystemUnique()
    {
        AudioSource.PlayClipAtPoint(ClickSFX, transform.position);
        SceneManager.LoadScene(3);
    }
}
