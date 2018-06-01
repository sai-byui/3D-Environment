using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Parser : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    InputField commandLine;
    NeoLegs neo;
    public static bool focused;
    //public static InputField prompt;
	// Use this for initialization
	void Awake () {
        commandLine = GetComponent<InputField>();
        neo = FindObjectOfType<NeoLegs>();
        //prompt = commandLine;
        //Parser.focused = prompt.isFocused;
	}
	
	// Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            string command = commandLine.text;
            commandLine.text = "";

            string[] words = command.Split();
            for (int i = 0; i < words.Length; i++)
            {
                //NLP Code here
                if (words[i] == "Dance")
                {
                    neo.Dance();
                }
                else if (words[i] == "Stop")
                    neo.Stop();
            }
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
