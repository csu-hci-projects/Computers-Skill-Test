using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickandDestroy : MonoBehaviour
{
    public GameController gameController;

    public Button one;
    public Button two;
    public Button three;
    public Button four;
    public Button five;
    public Button six;
    public Button seven;
    public Button eight;
    public Button nine;
    public Button ten;
    public Button eleven;
    public Button twelve;
    public Button thirteen;
    public Button fourteen;
    public Button fifteen;
    public Button doneButt; 
    public GameObject Panel;
    public bool gamePlaying;
    

    public void buttononeDeactive() {
        one.gameObject.SetActive(false);
    }
    public void buttontwoDeactive() {
        if(one.gameObject.activeSelf == false){
        two.gameObject.SetActive(false);
        }
    }
    public void buttonthreeDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false){
        three.gameObject.SetActive(false);
        }
    }
    public void buttonfourDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false){
        four.gameObject.SetActive(false);
        }
    }
    public void buttonfiveDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false){
            five.gameObject.SetActive(false);
        }
    }
    public void buttonsixDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false){
            six.gameObject.SetActive(false);
        }
    }
    public void buttonsevenDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false &&
        six.gameObject.activeSelf == false){
            seven.gameObject.SetActive(false);
        }
    }
    public void buttoneightDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false &&
        six.gameObject.activeSelf == false &&
        seven.gameObject.activeSelf == false){
            eight.gameObject.SetActive(false);
        }
    }
    public void buttonnineDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false &&
        six.gameObject.activeSelf == false &&
        seven.gameObject.activeSelf == false &&
        eight.gameObject.activeSelf == false){
            nine.gameObject.SetActive(false);
        }
        
    }
    public void buttontenDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false &&
        six.gameObject.activeSelf == false &&
        seven.gameObject.activeSelf == false &&
        eight.gameObject.activeSelf == false &&
        nine.gameObject.activeSelf == false){
            ten.gameObject.SetActive(false);
        }
    }
    public void buttonelevenDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false &&
        six.gameObject.activeSelf == false &&
        seven.gameObject.activeSelf == false &&
        eight.gameObject.activeSelf == false &&
        nine.gameObject.activeSelf == false &&
        ten.gameObject.activeSelf == false){
            eleven.gameObject.SetActive(false);
        }
    }
    public void buttontwelveDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false &&
        six.gameObject.activeSelf == false &&
        seven.gameObject.activeSelf == false &&
        eight.gameObject.activeSelf == false &&
        nine.gameObject.activeSelf == false &&
        ten.gameObject.activeSelf == false &&
        eleven.gameObject.activeSelf == false){
        twelve.gameObject.SetActive(false);
        }
    }
    public void buttonthirteenDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false &&
        six.gameObject.activeSelf == false &&
        seven.gameObject.activeSelf == false &&
        eight.gameObject.activeSelf == false &&
        nine.gameObject.activeSelf == false &&
        ten.gameObject.activeSelf == false &&
        eleven.gameObject.activeSelf == false &&
        twelve.gameObject.activeSelf == false){
            thirteen.gameObject.SetActive(false);
        }
    }
    public void buttonfourteenDeactive() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false &&
        six.gameObject.activeSelf == false &&
        seven.gameObject.activeSelf == false &&
        eight.gameObject.activeSelf == false &&
        nine.gameObject.activeSelf == false &&
        ten.gameObject.activeSelf == false &&
        eleven.gameObject.activeSelf == false &&
        twelve.gameObject.activeSelf == false &&
        thirteen.gameObject.activeSelf == false){
            fourteen.gameObject.SetActive(false);
        }
    }
    public void buttonfifteenDeactive() {
         if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false &&
        six.gameObject.activeSelf == false &&
        seven.gameObject.activeSelf == false &&
        eight.gameObject.activeSelf == false &&
        nine.gameObject.activeSelf == false &&
        ten.gameObject.activeSelf == false &&
        eleven.gameObject.activeSelf == false &&
        twelve.gameObject.activeSelf == false &&
        thirteen.gameObject.activeSelf == false &&
        fourteen.gameObject.activeSelf == false){
            fifteen.gameObject.SetActive(false);
        }
    }

    public void donePanel() {
        if(one.gameObject.activeSelf == false &&
        two.gameObject.activeSelf == false &&
        three.gameObject.activeSelf == false &&
        four.gameObject.activeSelf == false &&
        five.gameObject.activeSelf == false &&
        six.gameObject.activeSelf == false &&
        seven.gameObject.activeSelf == false &&
        eight.gameObject.activeSelf == false &&
        nine.gameObject.activeSelf == false &&
        ten.gameObject.activeSelf == false &&
        eleven.gameObject.activeSelf == false &&
        twelve.gameObject.activeSelf == false &&
        thirteen.gameObject.activeSelf == false &&
        fourteen.gameObject.activeSelf == false &&
        fifteen.gameObject.activeSelf == false){
            Panel.SetActive(true);
            //gameController.EndGame();
        }
    }
}
