using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterWalk : MonoBehaviour
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
        monsterAnimator.SetBool("walking", true);
    }
}
