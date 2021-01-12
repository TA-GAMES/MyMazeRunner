using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGateToNextLevel : MonoBehaviour
{
    [SerializeField] GameObject downWall;
    [SerializeField] GameObject upWall;
    public static bool open = false;

    void Update()
    {
        if (open && SceneManager.GetActiveScene().buildIndex == 2)
        {
            Destroy(downWall.gameObject);
            Destroy(upWall.gameObject);
        }

        if (ScoreScript.LevelScore == 200 && SceneManager.GetActiveScene().buildIndex == 3)
        {
            Destroy(downWall.gameObject);
            Destroy(upWall.gameObject);
        }
    }
}
