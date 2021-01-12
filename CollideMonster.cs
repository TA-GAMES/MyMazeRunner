using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component will make the player start the level over if he collides monster.
 */

public class CollideMonster : MonoBehaviour
{
    public GameObject killedByMonsterPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Monster" && enabled)
        {
            PlayerMoveControl.ready = false;
            killedByMonsterPanel.SetActive(true);
        }
    }
}
