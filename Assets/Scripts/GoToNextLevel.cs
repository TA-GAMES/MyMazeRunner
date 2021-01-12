using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    public void loadNextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        ScoreScript.LevelScore = 0;
        ApplesScore.apples = 0;
        KnifeScore.knifes = 0;
        LevelManager.finish = false;
    }
}
