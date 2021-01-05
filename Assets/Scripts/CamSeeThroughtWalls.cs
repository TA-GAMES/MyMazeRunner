using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSeeThroughtWalls : MonoBehaviour
{
    float minDis = 1.0f;
    float maxDis = 4.0f;
    float smooth = 10f;
    Vector3 dollyDir;
    public Vector3 dollyDirAdjusted;
    public float distance;

    void Awake()
    {
        dollyDir = transform.localPosition.normalized;
        distance = transform.localPosition.magnitude;
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 desiredCamPos = transform.parent.TransformPoint(dollyDir * maxDis);
        RaycastHit hit;

        if(Physics.Linecast(transform.parent.position, desiredCamPos, out hit))
        {
            distance = Mathf.Clamp(hit.distance, minDis, maxDis);
        }
        else
        {
            distance = maxDis;
        }
        transform.localPosition = Vector3.Lerp(transform.localPosition, dollyDir * distance, Time.deltaTime * smooth);
    }
}
