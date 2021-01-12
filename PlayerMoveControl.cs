using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveControl : MonoBehaviour
{
    Animator anim;
    public static bool ready = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //anim.SetBool("Idle", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ready = true;
        }
        if (ready)
        {
            anim.SetFloat("Vertical", Input.GetAxis("Vertical"));
            anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
            anim.SetBool("Running", Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W));
        }
    }
}
