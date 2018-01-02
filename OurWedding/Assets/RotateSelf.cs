using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour {

    public GameObject imageSprite;
	// Use this for initialization
	void Start () {
        imageSprite.transform.position = new Vector3(-25.0f,0.0f,0.0f);
        imageSprite.transform.eulerAngles = new Vector3(0.0f, 0.0f, 120.0f);
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 po = imageSprite.transform.position;

        if (po.x <= -4)
        {
            po = new Vector3((po.x += 0.5f), 0);
            imageSprite.transform.position = po;
            imageSprite.transform.Rotate(new Vector3(0, 0, 5));
        }

    }
}
