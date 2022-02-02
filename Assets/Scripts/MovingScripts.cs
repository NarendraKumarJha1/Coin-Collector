using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScripts : MonoBehaviour
{
    //public float minClamp;
    //public float maxClamp;
    //public float speed;
    //int y
    //public void Update()
    //{
    //    float y = Mathf.PingPong(Time.time * speed, 1) * 6 - 3;
    //    var pos = Mathf.Clamp(y, minClamp, maxClamp);
    //    gameObject.transform.position = new Vector3(transform.position.x, pos, transform.position.z);

    //}
    //public void Update()
    //{
    //    if (y >= 3)
    //    {
    //        y = y - speed * Time.deltaTime;
    //    }
    //    if (y < 3)
    //    {
    //        y = y + speed * Time.deltaTime;
    //    }
    //    apple.transform.position = new Vector3(0, y, 0);
    //}


    
    public int loopHeight = 10;
    public bool checkAtMax = false;
    public int minyClamp;
    public int maxyClamp;



    void Update()
    {

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, minyClamp, maxyClamp);
        transform.position = pos;

        if (checkAtMax)
        {
            for (int x = 0; x < loopHeight; ++x)
            {
                gameObject.transform.position -= new Vector3(0, transform.position.y, 0);
                if (x == loopHeight - 1)
                    checkAtMax = false;
            }
        }
        else
        {
            for (int x = 0; x < loopHeight; ++x)
            {
                gameObject.transform.position += new Vector3(0, transform.position.y, 0);
                if (x == loopHeight - 1)
                    checkAtMax = true;
            }
        }
    }

}
