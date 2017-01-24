﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAction : MonoBehaviour {

	public bool canInteract;
	public bool interactModeActivated = false;

	private GameObject shaderCube;
	private Color startColor;

	// Use this for initialization
	void Start () {

		startColor = GetComponent<Renderer>().material.color;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.I)) {
			if (canInteract == true) {

				if (interactModeActivated == true) {
					GetComponent<Renderer>().material.color = startColor;
					interactModeActivated = false;
				} else {
					GetComponent<Renderer>().material.color = Color.blue;
					interactModeActivated = true;
				}
			}
		} 
	}

	public void ExecuteCubeAction() {
		// EXECUTE ACTION
	}

	void OnMouseExit() {
		if (User.gazeControlMode == false & canInteract == true) {
			if (interactModeActivated == false) {
				GetComponent<Renderer>().material.color = startColor;
			} else {
				GetComponent<Renderer>().material.color = Color.blue;
			}
		}
	}

	void OnMouseDown() {
		if (User.gazeControlMode == false & interactModeActivated == true && canInteract == true) {
			GetComponent<Renderer>().material.color = Color.green;
		}
	}
}
