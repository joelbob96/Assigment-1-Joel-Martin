﻿
using UnityEngine;
using UnityEngine.UI;

public class SendText : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void storeName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Player: " + theName;
    }
}
