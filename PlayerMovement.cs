﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
    Rigidbody2D rbody;
    Animator anim;
    
    void Start () {

        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	void Update () {

        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movement_vector != Vector2.zero) 
        {
            anim.SetBool("IsMoving", true);
            anim.SetFloat("Input_x", movement_vector.x);
            anim.SetFloat("Input_y", movement_vector.y);
        } else 
        {
            anim.SetBool("IsMoving", false);
        }

        rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime);
	}
}
