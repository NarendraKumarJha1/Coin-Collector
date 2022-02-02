using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
public class MovingScripts : MonoBehaviour
{
    [SerializeField]
    float period = 2f;
    [SerializeField]
    Vector3 MovementFactor = new Vector3(10f, 10f, 10f);
    [Range(0, 1)] [SerializeField] float movementSlider;
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cycle = Time.time / period;
        const float tau = Mathf.PI * 2f;
        float rawSineWave = Mathf.Sin(cycle * tau);
        movementSlider = rawSineWave / 2f + 0.5f;

        Vector3 offset = movementSlider * MovementFactor;
        transform.position = offset + originalPos;
    }
}
