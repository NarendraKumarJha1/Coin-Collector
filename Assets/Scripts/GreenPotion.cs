using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPotion : MonoBehaviour
{
    [SerializeField] Transform sfx;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        Instantiate(sfx, new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity);
        Destroy(sfx, 1f);
    }
}
