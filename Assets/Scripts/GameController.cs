using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject panel;
    public Text finalTime;

    public Text timeCounter;
    TimeSpan timePlaying;
    public bool gamePlaying;

    private float startTime, elapsedTime;

    private void Start() {
        BeginGame();
    }

    private void Awake() {
        instance = this;
    }

    private void BeginGame(){
        gamePlaying = true;
        startTime = Time.time;
        //TimerController.instance.BeginTimer();
   }
    private void Update (){
        
        if(gamePlaying) {
            elapsedTime = Time.time - startTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime); 

            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;
            if(panel.gameObject.activeSelf == true){
                EndGame();
            }
        }
    }
   public void EndGame() {
       gamePlaying = false;
       ShowDoneScreen();
   }

   private void ShowDoneScreen(){
        string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
        finalTime.text = timePlayingStr;
        // panel.transform.Find("FinalTime").GetComponent<Text>().text = timePlayingStr;

   }
}
