using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * This component will make the target object shown once the player wanna put it in place
 */

public class PlaceObject : MonoBehaviour
{
    [SerializeField] GameObject ga;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TargetPlace" && enabled)
        {
            if (ScoreScript.LevelScore == 100)
            {
                ga.gameObject.SetActive(true);
                ScoreScript.playerScore += 100;
                ScoreScript.LevelScore += 100;
            }
            
        }
    }
}
