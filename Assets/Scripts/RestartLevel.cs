using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void startOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreScript.playerScore = ScoreScript.playerScore - ScoreScript.LevelScore;
        ScoreScript.LevelScore = 0;
        ApplesScore.apples = 0;
        KnifeScore.knifes = 0;
        OpenGateToNextLevel.open = false;
    }
}
