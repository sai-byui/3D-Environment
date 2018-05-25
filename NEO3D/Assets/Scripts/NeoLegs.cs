using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NeoLegs : MonoBehaviour {
	
	public float speed = 6.0F;
	public float rotationSpeed = 2f;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	private Vector3 moveDirection = Vector3.zero;
	private Rigidbody rig;

    NavMeshAgent agent;

	void Start(){
		rig = GetComponent<Rigidbody> ();
        agent = GetComponent<NavMeshAgent>();
	}

	void Update() {
		transform.Rotate (new Vector3 (0, Input.GetAxis("Horizontal"), 0) * rotationSpeed);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;


            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                agent.destination = hit.point;
                Debug.DrawRay(Camera.main.transform.position, hit.point, Color.red, 3f);
            }
        }
	}

	void FixedUpdate(){
		moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		rig.AddForce (moveDirection);
	}
}
