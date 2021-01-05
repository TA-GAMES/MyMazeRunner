using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGateToNextLevel : MonoBehaviour
{
    [SerializeField] GameObject downWall;
    [SerializeField] GameObject upWall;

    void Update()
    {
        if (ScoreScript.LevelScore == 200 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            Destroy(downWall.gameObject);
            Destroy(upWall.gameObject);
        }
    }
}
