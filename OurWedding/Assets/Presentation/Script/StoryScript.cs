using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryScript : MonoBehaviour {


    public int step;
    public GameObject player;
	// Use this for initialization
	void Start () {
        step = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(step == 0)
        {
            player.GetComponent<PlayerController>().WalkLeft();

            if(player.transform.position.x <= -1.5)
            {
                step = 1;
            }
        }
        else if(step == 1)
        {
            player.GetComponent<PlayerController>().WalkUp();

            if (player.transform.position.y >= 1.5)
            {
                step = 2;
            }
        }
        else if (step == 2)
        {
            player.GetComponent<PlayerController>().WalkRight();

            if (player.transform.position.x >= 1.5)
            {
                step = 3;
            }
        }

    }
}
