﻿using UnityEngine;
using System.Collections;

public class CameraBehavier : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(1, 0, 0), -Input.GetAxis("Mouse Y"));
    }
}
