using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject openPanel;
    public GameObject closePanel;
    
    public void ClosePanel (){
        closePanel.SetActive(false);
    }
    public void OpenPanel (){
        openPanel.SetActive(true);
    }
    
}
