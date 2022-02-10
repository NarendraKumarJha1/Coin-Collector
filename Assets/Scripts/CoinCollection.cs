using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinCollection : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI CoinScore;

    [SerializeField]
    TextMeshProUGUI CoinScoreGameOver;

    [SerializeField]
    GameObject InitialUI;

    [SerializeField]
    AudioClip coinSFX;

    [SerializeField]
    AudioClip potionSFX;

    [SerializeField]
    GameObject GameOverUI;

    [SerializeField]
    GameObject WinScreenUI;

    private Animator scoreAnim;
    public GameObject ScoreUI;

    int CoinCount = 0;


    void Start()
    {
        scoreAnim = ScoreUI.GetComponent<Animator>();
        CoinScore.text = "XX";
        GameOverUI.SetActive(false);
        WinScreenUI.SetActive(false);
    }



    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Potion"))
        {
            AudioSource.PlayClipAtPoint(potionSFX, transform.localPosition);
            CoinCount += 5;
            CoinScore.text = CoinCount.ToString();
            other.gameObject.SetActive(false);
            Destroy(other.gameObject, 1f);
            scoreAnim.SetTrigger("Set");
        }
        else if (other.gameObject.CompareTag("Coin"))
        {
            AudioSource.PlayClipAtPoint(coinSFX, transform.localPosition);
            CoinCount += 1;
            CoinScore.text = CoinCount.ToString();
            other.gameObject.SetActive(false);
            Destroy(other.gameObject, 1f);
            scoreAnim.SetTrigger("Set");
        }
        else if (other.gameObject.CompareTag("Finish"))
        {
            CoinScoreGameOver.text = CoinCount.ToString();
            Time.timeScale = 0f;
            GameOverUI.SetActive(true);
            InitialUI.SetActive(false);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pandora"))
        {
            Time.timeScale = 0f;
            WinScreenUI.SetActive(true);
        }
    }
}
