using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Systemid : MonoBehaviour
{
    public TextMeshProUGUI systemId;
    // Start is called before the first frame update
    void Start()
    {
        systemId.text = SystemInfo.deviceUniqueIdentifier;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
