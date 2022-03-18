using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateAnim : MonoBehaviour
{
    Animator gateAnim;
    // Start is called before the first frame update
    void Start()
    {
        gateAnim = gameObject.GetComponent<Animator>();
        gateAnim.SetTrigger("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gateAnim.SetTrigger("startOpen");
            var coll = gameObject.GetComponent<Collider>();
            Destroy(coll, 10f);
            StartCoroutine(SwitchScene());
        }
    }

    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(4);
    }
}
