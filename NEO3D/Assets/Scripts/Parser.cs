using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Parser : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    InputField commandLine;
    public static bool focused;
    //public static InputField prompt;
	// Use this for initialization
	void Awake () {
        commandLine = GetComponent<InputField>();
        //prompt = commandLine;
        //Parser.focused = prompt.isFocused;
	}
	
	// Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.Tab))
        {
            
        }
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        //print("ENTER!");
        focused = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //print("EXIT!");
        focused = false;
    }

}
