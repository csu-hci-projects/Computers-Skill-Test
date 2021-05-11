using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelDelayOpener : MonoBehaviour
{

    public GameObject PanelOne;
    public GameObject PanelTwo;
    public GameObject PanelThree;
    public GameObject QPanelOne;
    public GameObject QPanelTwo;
    public GameObject QPanelThree;
    public GameObject FinalPanel;
    public float delayTime;
    public bool oneOpened = false;
    public bool twoOpened = false;
    public bool threeOpened = false;

    // Start is called before the first frame update
    void Start() {
        //close panel one after two seconds
        Invoke("closePanelOneAfterDelay", 2);

        //Open question panel one after 2 secs and close after 7
        Invoke("openQPanelOneAfterDelay", 2);
        Invoke("closeQPanelOneAfterDelay", 7);

        //open panel two after 7 and close after 9
        Invoke("openPanelTwoAfterDelay", 7);
        Invoke("closePanelTwoAfterDelay", 9);

        //open question panel two after 9 seconds and close after 14
        Invoke("openQPanelTwoAfterDelay", 9);
        Invoke("closeQPanelTwoAfterDelay", 14);
        
        //open panel three after 14 seconds and close after 16
        Invoke("openPanelThreeAfterDelay", 14);
        Invoke("closePanelThreeAfterDelay", 16);

        //open question panel three after 16 seconds and close after 21
        Invoke("openQPanelThreeAfterDelay", 16);
        Invoke("closeQPanelThreeAfterDelay", 21);

        Invoke("openFinalPanel", 21);

    }

    void Update() {
        // if(oneOpened == true && PanelOne.gameObject.activeSelf == false){
        //     QPanelOne.gameObject.SetActive(true);
        // }
        // if(twoOpened == true && PanelTwo.gameObject.activeSelf == false){
        //     PanelTwo.gameObject.SetActive(false);
        //     QPanelTwo.gameObject.SetActive(true);
            
        // }
        // if(threeOpened == true && PanelThree.gameObject.activeSelf == false){
        //     QPanelThree.gameObject.SetActive(true);
        // }
    }

    public void closePanelOneAfterDelay() {
        PanelOne.gameObject.SetActive(false);
        //oneOpened = true;
    }

     public void openQPanelOneAfterDelay() {
        QPanelOne.gameObject.SetActive(true);
    }
    public void closeQPanelOneAfterDelay() {
        QPanelOne.gameObject.SetActive(false);
        //twoOpened = true;
    }

    public void openPanelTwoAfterDelay() {
        PanelTwo.gameObject.SetActive(true);
    }
    public void closePanelTwoAfterDelay() {
        PanelTwo.gameObject.SetActive(false);
        //twoOpened = true;
    }

    public void openQPanelTwoAfterDelay() {
        QPanelTwo.gameObject.SetActive(true);
    }
    public void closeQPanelTwoAfterDelay() {
        QPanelTwo.gameObject.SetActive(false);
        //twoOpened = true;
    }

    public void openPanelThreeAfterDelay() {
        PanelThree.gameObject.SetActive(true);
    }
    public void closePanelThreeAfterDelay() {
        PanelThree.gameObject.SetActive(false);
        //threeOpened = true;
    }

     public void openQPanelThreeAfterDelay() {
        QPanelThree.gameObject.SetActive(true);
    }
    public void closeQPanelThreeAfterDelay() {
        QPanelThree.gameObject.SetActive(false);
        //threeOpened = true;
    }

    public void openFinalPanel() {
        FinalPanel.gameObject.SetActive(true);
    }
}
