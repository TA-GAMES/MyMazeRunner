using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillMonster : MonoBehaviour
{
    private System.Random random = new System.Random();
    public GameObject killedByMonsterPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Monster" && enabled)
        {
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                double chanceToKill = random.NextDouble();
                if (chanceToKill <= (KnifeScore.knifes / 5))
                {
                    Destroy(other.gameObject);
                    ScoreScript.LevelScore += 100;
                    ScoreScript.playerScore += 100;
                    OpenGateToNextLevel.open = true;
                }
                else
                {
                    PlayerMoveControl.ready = false;
                    killedByMonsterPanel.SetActive(true);
                }
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                if (KnifeScore.knifes == 1)
                {
                    Destroy(other.gameObject);
                    ScoreScript.LevelScore += 100;
                    ScoreScript.playerScore += 100;
                    KnifeScore.knifes = 0;
                }
                else
                {
                    PlayerMoveControl.ready = false;
                    killedByMonsterPanel.SetActive(true);
                }
            }
        }
    }
}
