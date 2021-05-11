using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEntryConfirm : MonoBehaviour
{
    public GameObject Panel;
    public Text input;
    public Text wpm;
    public Text finalTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(input.text == "In the age of computers, this pangram is commonly used to display font samples and for testing computer keyboards: The quick brown fox jumped over the lazy dog."){
            Panel.gameObject.SetActive(true);
            string finalWpm = finalTime.text;
            string finalWpmSeconds = finalWpm.Substring(9,2);
            string finalWpmMinutes = finalWpm.Substring(6,2);
            float secondsVal = Convert.ToSingle(finalWpmSeconds);
            float minutesVal = Convert.ToSingle(finalWpmMinutes);
            float wordAmount = 32;
            float finalWpmFloat = wordAmount / ((minutesVal) + (secondsVal/60));
            string finalWpmString = finalWpmFloat.ToString("n2");
            string wpmStringForm = finalWpmString.Substring(0);
            wpm.text = "WPM: " + wpmStringForm;

        }
    }

    public void ReadStringInput(string str){
        // input = str;
    }
}
