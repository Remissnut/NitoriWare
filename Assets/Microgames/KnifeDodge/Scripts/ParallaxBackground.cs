﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour {

	float speed = 1; // speed in meters per second

	// Use this for initialization
	void Start () {

	}

	void Update(){
		// move this object at frame rate independent speed:
		transform.position += new Vector3(1,0,0) * speed * Time.deltaTime;
	}

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public float GetSpeed() { return speed; }
}
