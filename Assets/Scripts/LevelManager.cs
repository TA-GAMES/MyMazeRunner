using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject levelIntroUI;
    public GameObject completeLevelUI;

    void Update()
    {
       if (Input.GetKey(KeyCode.Space))
        {
            levelIntroUI.SetActive(false);
        }

        if (ScoreScript.LevelScore == 200 && SceneManager.GetActiveScene().buildIndex == 0)
        {
            CompleteLevel();
        }

        if (ScoreScript.LevelScore == 200 && SceneManager.GetActiveScene().buildIndex == 1)
        {
            CompleteLevel();
        }

        if (ScoreScript.LevelScore == 300 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            CompleteLevel();
        }
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
