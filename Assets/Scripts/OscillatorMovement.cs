using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillatorMovement : MonoBehaviour
{
    [Tooltip("The frequency of the movement")]
    [SerializeField]
    float frequency = 10f;

    [Tooltip("distance of the movement")]
    [SerializeField]
    float distance = 5f;

    Vector3 loc;

    // Start is called before the first frame update
    void Start()
    {
        loc = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = loc + transform.forward * Mathf.Sin(Time.time * frequency) * distance;
    }
}
