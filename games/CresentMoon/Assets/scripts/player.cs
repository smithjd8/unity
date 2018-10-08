using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    // instance variables 
    [SerializeField]
    private float speed = 3;
    private Vector2 direction;

    [SerializeField]
    private Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // move character
        move();
        ListenForKey();

    }

    public void move()
    {

        transform.Translate(direction*speed*Time.deltaTime);
    }

    private void ListenForKey()
    {

        direction = Vector2.zero;

       

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector2.up;
            animator.Play("walk_up");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down;
            animator.Play("walk_down");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
            animator.Play("walk_left");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector2.right;
            animator.Play("walk_right");
        }



    }
}
