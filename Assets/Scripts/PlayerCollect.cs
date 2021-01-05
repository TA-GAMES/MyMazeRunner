using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component allowed the player to collect object
 */

public class PlayerCollect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && enabled)
        {
            if (this.tag == "Target")
            {
                Destroy(this.gameObject);
                ScoreScript.playerScore += 100;
                ScoreScript.LevelScore += 100;
            }

            else if (this.tag == "Apple")
            {
                Destroy(this.gameObject);
                ScoreScript.playerScore += 50;
                ScoreScript.LevelScore += 50;
            }

            else if (this.tag == "Gate")
            {
                ScoreScript.playerScore += 100;
                ScoreScript.LevelScore += 100;
            }
        }
    }
}
