using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chaser : MonoBehaviour
{
    [SerializeField] GameObject targetToChase;
    [SerializeField] float speed = 3.5f;
    NavMeshAgent navmsah;
    

    // Start is called before the first frame update
    void Start()
    {
        navmsah = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetToChase.transform);
        //transform.position += transform.forward * speed * Time.deltaTime;
        navmsah.SetDestination(targetToChase.transform.position);
    }
}
