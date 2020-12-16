using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float walkSpeed;

    private Animator animate;
    private bool PlayerMoving;
    private Vector2 lastMove;
	
	void Start () {
        animate = GetComponent<Animator>();

        
	}
	
	void Update () {

        PlayerMoving = false;
        if (Input.GetAxis("Horizontal") > 0.5 || Input.GetAxis("Horizontal") < -0.5)
        {
            transform.Translate(new Vector3(Input.GetAxis("Horizontal")*walkSpeed*Time.deltaTime,0f,0f));
            PlayerMoving = true;
            lastMove = new Vector2 (Input.GetAxis("Horizontal"), 0f);
        }
        if (Input.GetAxis("Vertical") > 0.5f || Input.GetAxis("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime, 0f));
            PlayerMoving = true;
            lastMove = new Vector2(0f,Input.GetAxis("Vertical"));
        }

        animate.SetFloat("MoveX",Input.GetAxis("Horizontal"));
        animate.SetFloat("MoveY",Input.GetAxis("Vertical"));
        animate.SetBool("PlayerMoving",PlayerMoving);
        animate.SetFloat("LastMoveX",lastMove.x);
        animate.SetFloat("LastMoveY",lastMove.y);
	}
}
