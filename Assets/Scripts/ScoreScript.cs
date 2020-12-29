using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * This component shows the player score
 */

public class ScoreScript : MonoBehaviour
{
    public static int playerScore = 0;
    public static int LevelScore = 0;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : " + playerScore;
    }
}
