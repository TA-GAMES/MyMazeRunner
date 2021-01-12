using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeScore : MonoBehaviour
{
    public static int knifes = 0;
    Text knifesCollectedInlevel;

    // Start is called before the first frame update
    void Start()
    {
       knifesCollectedInlevel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        knifesCollectedInlevel.text = "Knifes : " + knifes + " out of 5";
    }
}
