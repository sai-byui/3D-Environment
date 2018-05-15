using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	public Camera neoView;
	Rect miniView = new Rect(new Vector2(0, .75f), new Vector2(.25f, .25f));
	Rect fullView = new Rect (new Vector2 (0, 0), new Vector2 (1, 1));
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (neoView.rect == miniView)
				neoView.rect = fullView;
			else
				neoView.rect = miniView;
		}
	}
}
