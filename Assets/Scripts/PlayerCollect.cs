using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component aloowed the player to collect object
 */

public class PlayerCollect : MonoBehaviour
{
    [SerializeField] GameObject target;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == target.tag && enabled)
        {
            Destroy(target);
            ScoreScript.playerScore += 100;
            ScoreScript.LevelScore += 100;
        }
    }
}
