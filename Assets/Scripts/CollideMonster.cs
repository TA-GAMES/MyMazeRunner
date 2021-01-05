using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component will make the player start the level over if he collides monster.
 */

public class CollideMonster : MonoBehaviour
{

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Monster" && enabled)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            ScoreScript.playerScore = ScoreScript.playerScore - ScoreScript.LevelScore;
            ScoreScript.LevelScore = 0;
        }
    }
}
