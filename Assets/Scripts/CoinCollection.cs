using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinCollection : MonoBehaviour
{
    [Header("SFX")]
    [SerializeField]
    AudioClip coinSFX;
    [SerializeField]
    AudioClip potionSFX;

    [Header("TMP")]
    [SerializeField]
    TextMeshProUGUI CoinScore;
    [SerializeField]
    TextMeshProUGUI CoinScoreGameOver;
    [SerializeField]
    TextMeshProUGUI CoinScorePausedUI;

    [Header("UI")]
    [SerializeField]
    GameObject InitialUI;
    [SerializeField]
    GameObject GameOverUI;
    [SerializeField]
    GameObject WinScreenUI;
    [SerializeField]
    GameObject pausedScreen;
    public GameObject ScoreUI;

    [Header("VFX")]
    [SerializeField]
    ParticleSystem coinDestroyVFX;

    private Animator scoreAnim;
    

    int CoinCount = 0;


    void Start()
    {
        scoreAnim = ScoreUI.GetComponent<Animator>();
        CoinScore.text = "XX";
        GameOverUI.SetActive(false);
        WinScreenUI.SetActive(false);
        pausedScreen.SetActive(false);
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
            DestroyImmediate(other.gameObject);
            scoreAnim.SetTrigger("Set");
        }
        else if (other.gameObject.CompareTag("Coin"))
        {
            AudioSource.PlayClipAtPoint(coinSFX, transform.localPosition);
            CoinCount += 1;
            CoinScore.text = CoinCount.ToString();
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            ParticleSystem destroyVFX= Instantiate(coinDestroyVFX,other.transform.position,Quaternion.identity);
            Destroy(destroyVFX, 1f);
            scoreAnim.SetTrigger("Set");
        }
        else if (other.gameObject.CompareTag("Finish"))
        {
            CoinScoreGameOver.text = CoinCount.ToString();
            CoinScorePausedUI.text = CoinCount.ToString();
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
    public GameObject GetInitialUI()
    {
        return InitialUI;
    }
}
