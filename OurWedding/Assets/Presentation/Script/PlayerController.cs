using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    Animator anim;
    SpriteRenderer render;
    Rigidbody2D rigid;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
	}

    
	
	// Update is called once per frame
	void Update () {
		/*if((Input.GetAxisRaw("Horizontal") > 0.5) || (Input.GetAxisRaw("Horizontal") < -0.5))
        {
            transform.Translate(new Vector3((Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime), 0.0f, 0.0f));
        }
        if ((Input.GetAxisRaw("Vertical") > 0.5) || (Input.GetAxisRaw("Vertical") < -0.5))
        {
            transform.Translate(new Vector3(0.0f, (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime), 0.0f));
        }

        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            anim.SetBool("moveX", true);
            anim.SetBool("moveUp", false);
            anim.SetBool("moveDown", false);
            render.flipX = true;
            anim.speed = 1;
            
        }
        else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            anim.SetBool("moveX", true);
            anim.SetBool("moveUp", false);
            anim.SetBool("moveDown", false);
            render.flipX = false;
            anim.speed = 1;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            anim.SetBool("moveX", false);
            anim.SetBool("moveUp", false);
            anim.SetBool("moveDown", true);
            
            anim.speed = 1;
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            anim.SetBool("moveX", false);
            anim.SetBool("moveUp", true);
            anim.SetBool("moveDown", false);
           
            anim.speed = 1;
        }
        else
        {
            anim.speed = 0;
        }*/
    }

    public void WalkRight()
    {
        transform.Translate(new Vector3((0.5f * moveSpeed * Time.deltaTime), 0.0f, 0.0f));
        anim.SetBool("moveX", true);
        anim.SetBool("moveUp", false);
        anim.SetBool("moveDown", false);
        render.flipX = true;
        anim.speed = 1;
    }

    public void WalkLeft()
    {
        transform.Translate(new Vector3((-0.5f * moveSpeed * Time.deltaTime), 0.0f, 0.0f));
        anim.SetBool("moveX", true);
        anim.SetBool("moveUp", false);
        anim.SetBool("moveDown", false);
        render.flipX = false;
        anim.speed = 1;
    }

    public void WalkUp()
    {
        transform.Translate(new Vector3(0.0f, (0.5f * moveSpeed * Time.deltaTime), 0.0f));
        anim.SetBool("moveX", false);
        anim.SetBool("moveUp", true);
        anim.SetBool("moveDown", false);
        
        anim.speed = 1;
    }

    public void WalkDown()
    {
        transform.Translate(new Vector3(0.0f, (-0.5f * moveSpeed * Time.deltaTime), 0.0f));
        anim.SetBool("moveX", false);
        anim.SetBool("moveUp", false);
        anim.SetBool("moveDown", true);
        anim.speed = 1;
    }
}
