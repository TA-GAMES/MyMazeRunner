using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    [SerializeField] GameObject targetToChase;
    [SerializeField] float speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetToChase.transform);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
