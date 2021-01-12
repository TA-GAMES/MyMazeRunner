using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject levelIntroUI;
    public GameObject completeLevelUI;
    public static bool finish = false;

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

        if (SceneManager.GetActiveScene().buildIndex == 2 && finish)
        {
            CompleteLevel();
        }

        if (SceneManager.GetActiveScene().buildIndex == 3 && finish)
        {
            CompleteLevel();
        }


    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
