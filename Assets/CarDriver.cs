﻿using UnityEngine;
using System.Collections;

public class CarDriver : MonoBehaviour {
	public float forwardSpeed = 5.0f;
	public float backwardsSpeed = 2.0f;
	public float turnRate = 80.0f;

	public Transform LowestObjectPosition;
	public Transform RespawnPosition;

	public Transform CurrentRespawnPosition;

	public GUIText deathCountOutput;
	public int deathCount = 0; 
	public GUIText introOutput;
	public string intro = "Simple Car Course By: Garrett Barr";
	
	// Use this for initialization
	void Start () {
		CurrentRespawnPosition = RespawnPosition;
	}

	public void Respawn(){			
		transform.position = CurrentRespawnPosition.position;
		transform.rotation = CurrentRespawnPosition.rotation;
		rigidbody.velocity = Vector3.zero;
		rigidbody.angularVelocity = Vector3.zero;
		deathCount++;
	}

	// Update is called once per frame
	void Update () {
		introOutput.text = "" + intro;
		deathCountOutput.text = "Death Count: " + deathCount;

		if (Input.GetKey (KeyCode.Escape))
			Application.Quit ();
		if (transform.position.y < LowestObjectPosition.position.y) {
			Respawn();
		}
		if(Input.GetKey(KeyCode.W))
			transform.position += transform.forward * forwardSpeed * Time.deltaTime;
		if(Input.GetKey(KeyCode.S))
			transform.position -= transform.forward * backwardsSpeed * Time.deltaTime;
		if(Input.GetKey (KeyCode.A))
		   transform.Rotate(0.0f, -turnRate *Time.deltaTime, 0.0f);
		if(Input.GetKey (KeyCode.D))
			transform.Rotate(0.0f, turnRate *Time.deltaTime, 0.0f);
		if (Input.GetKeyDown (KeyCode.X)) {
			transform.position += Vector3.up;
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
			transform.rotation = Quaternion.LookRotation(transform.forward, Vector3.up);
			deathCount++;
		}

	}
}
