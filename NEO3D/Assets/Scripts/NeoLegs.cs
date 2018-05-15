using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeoLegs : MonoBehaviour {
	
	public float speed = 6.0F;
	public float rotationSpeed = 2f;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;
	private Rigidbody rig;

	void Start(){
		controller = GetComponent<CharacterController>();
		rig = GetComponent<Rigidbody> ();
	}

	void Update() {
		transform.Rotate (new Vector3 (0, Input.GetAxis("Horizontal"), 0) * rotationSpeed);
		/*if (controller.isGrounded) {
			moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			//if (Input.GetButton("Jump"))
			//	moveDirection.y = jumpSpeed;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);*/


	}

	void FixedUpdate(){
		moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		rig.AddForce (moveDirection);
	}
}
