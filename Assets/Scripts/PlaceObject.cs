using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component will make the target object shown once the player wanna put it in place
 */

public class PlaceObject : MonoBehaviour
{
    [SerializeField] GameObject ga;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && enabled)
        {
            if (ScoreScript.playerScore == 100)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    ga.gameObject.SetActive(true);
                    ScoreScript.playerScore += 100;
                }
            }
        }
    }
}
