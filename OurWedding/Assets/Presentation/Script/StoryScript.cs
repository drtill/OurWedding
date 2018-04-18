using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryScript : MonoBehaviour {


    public int step;
    public GameObject Knot;
    public GameObject Katai;
    public GameObject NPC;

    private PlayerController KnotController;
    private PlayerController KataiController;
    // Use this for initialization
    void Start () {
        step = 0;

        KnotController = Knot.GetComponent<PlayerController>();
        KataiController = Katai.GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {
        if(step == 0)
        {
            KnotController.WalkLeft();

            if(KnotController.GetPosition().x <= -1.5)
            {
                step = 1;
            }
        }
        else if(step == 1)
        {
            KnotController.WalkUp();

            if (KnotController.GetPosition().y >= 1.5)
            {
                step = 2;
            }
        }
        else if (step == 2)
        {
            KnotController.WalkRight();

            if (KnotController.GetPosition().x >= 1.5)
            {
                step = 3;
            }
        }

    }
}
