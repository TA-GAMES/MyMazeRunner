using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplesScore : MonoBehaviour
{
    public static int apples = 0;
    Text applesCollectedInlevel;
     
    // Start is called before the first frame update
    void Start()
    {
        applesCollectedInlevel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        applesCollectedInlevel.text = "Apples : " + apples + " out of 4";
    }
}
