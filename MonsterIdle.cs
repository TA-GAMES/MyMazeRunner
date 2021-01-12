using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component controls the moster animation
 */

public class MonsterIdle : MonoBehaviour
{
    Animator monsterAnimator;
    // Start is called before the first frame update
    void Start()
    {
        monsterAnimator = GetComponent<Animator>();
        monsterAnimator.SetBool("idle", true);
    }

    // Update is called once per frame
    void Update()
    {
        monsterAnimator.SetBool("idle", true);
    }
}
