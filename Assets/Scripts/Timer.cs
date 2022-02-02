using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Timer : MonoBehaviour
{
    public int countdownTime;
    public Text countDownDisplay;
    AudioSource beep;
    private void Start()
    {
        StartCoroutine(CountDownToStart());
        beep = GetComponent<AudioSource>();
    }
    IEnumerator CountDownToStart()
    {
        while (countdownTime >= 0)
        {
            countDownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
            beep.Play();

        }
        countDownDisplay.gameObject.SetActive(false);
        Reset();

    }

    private void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
