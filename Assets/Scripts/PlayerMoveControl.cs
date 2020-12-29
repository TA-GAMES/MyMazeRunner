using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveControl : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //anim.SetBool("Idle", true);
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        anim.SetBool("Running", Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W));
        //anim.SetBool("Run", Input.GetKey(KeyCode.LeftShift));
        //anim.SetBool("Walk", Input.GetKey(KeyCode.UpArrow));
        //anim.SetBool("GoLeft", Input.GetKey(KeyCode.LeftArrow));
        //anim.SetBool("GoRight", Input.GetKey(KeyCode.RightArrow));
    }
}
