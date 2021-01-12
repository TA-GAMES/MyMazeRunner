using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillatorMovement : MonoBehaviour
{
    [Tooltip("The frequency of the movement")]
    [SerializeField]
    float frequency = 0.5f;

    [Tooltip("distance of the movement")]
    [SerializeField]
    float distance = 5f;

    float _check;
    bool flag=false;
    Vector3 loc;

    // Start is called before the first frame update
    void Start()
    {
        loc = transform.position;
        _check = Mathf.Sin(Time.time * frequency);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = loc + transform.forward * Mathf.Sin(Time.time * frequency) * distance;
    }
}
