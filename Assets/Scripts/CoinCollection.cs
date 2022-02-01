using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinCollection : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI CoinScore;

    [SerializeField]
    AudioClip coinSFX;

    [SerializeField]
    AudioClip potionSFX;

    int CoinCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        CoinScore.text = "XX";
    }

    // Update is called once per frame
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
        }
        else if (other.gameObject.CompareTag("Coin"))
        {
            AudioSource.PlayClipAtPoint(coinSFX, transform.localPosition);
            CoinCount += 1;
            CoinScore.text = CoinCount.ToString();
            other.gameObject.SetActive(false);
            Destroy(other.gameObject, 1f);
        }

    }
}
