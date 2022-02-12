using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPotion : MonoBehaviour
{
    [SerializeField] Transform sfx;


    public Vector3 pos;
        



    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        Instantiate(sfx, pos,Quaternion.identity);
        Destroy(sfx, 1f);
    }
}
