using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel2 : MonoBehaviour
{

    [SerializeField] string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.LevelScore == 200)
        {
            SceneManager.LoadScene(sceneName);
            ScoreScript.LevelScore = 0;
        }
    }
}
