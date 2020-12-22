using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component controls the moster animation
 */

public class Monster : MonoBehaviour
{
    Animator monsterAnimator;
    // Start is called before the first frame update
    void Start()
    {
        monsterAnimator = GetComponent<Animator>();
        monsterAnimator.SetBool("walking", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
