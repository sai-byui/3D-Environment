﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NeoLegs : MonoBehaviour {
	
	public float speed = 6.0F;
	public float rotationSpeed = 2f;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
    bool dancing;

	private Vector3 moveDirection = Vector3.zero;
	private Rigidbody rig;

    NavMeshAgent agent;

	void Start(){
		rig = GetComponent<Rigidbody> ();
        agent = GetComponent<NavMeshAgent>();
	}

    void Update() {
        if (Input.GetMouseButtonDown(0) && !Parser.focused)
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                agent.destination = hit.point;
                Debug.DrawRay(Camera.main.transform.position, hit.point, Color.red, 3f);
            }
        }
        if (dancing)
            transform.Rotate(new Vector3(1,1,1));
	}

    public void Dance()
    {
        dancing = true;
    }
    public void Stop()
    {
        dancing = false;
    }
}
