using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveChoice : MonoBehaviour {
    public GameObject Panel;
    public Text enter;
    public Text exclam;
    public Text percent;
    public Text Y;
    public Text question;
    public Text L;
    public Text F;
    public Text money;
    public Text asterisk;
    public Text plus;
    public Text spacebar;
    public Text R;
    public Text B;
    public Text colon;
    public Text at;
    public Text G;
    public Text K;
    public Text pound;
    public Text E;
    public Text O;
    public Text nine;
    public Text greaterthan;
    public Text tab;
    public Text W;
    public Text underscore;
    public Text V;
    public Text M;
    public Text pipe;
    public Text U;
    public Text J;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Return)){
            enter.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("1")){
            exclam.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("5")){
            percent.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("y")){
            Y.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("/")){
            question.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("l")){
            L.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("f")){
            F.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("4")){
            money.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("8")){
            asterisk.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("=")){
            plus.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            spacebar.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("r")){
            R.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("b")){
            B.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown(KeyCode.Semicolon)){
            colon.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("2")){
            at.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("g")){
            G.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("k")){
            K.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("3")){
            pound.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("e")){
            E.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("o")){
            O.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("9")){
            nine.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown(".")){
            greaterthan.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown(KeyCode.Tab)){
            tab.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("w")){
            W.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("-")){
            underscore.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("v")){
            V.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("m")){
            M.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown(KeyCode.Backslash)){
            pipe.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("u")){
            U.gameObject.SetActive(false); 
        }
        if(Input.GetKeyDown("j")){
            J.gameObject.SetActive(false); 
        }
        if(enter.gameObject.activeSelf == false &&
        exclam.gameObject.activeSelf == false &&
        percent.gameObject.activeSelf == false &&
        Y.gameObject.activeSelf == false &&
        question.gameObject.activeSelf == false &&
        L.gameObject.activeSelf == false &&
        F.gameObject.activeSelf == false &&
        money.gameObject.activeSelf == false &&
        asterisk.gameObject.activeSelf == false &&
        plus.gameObject.activeSelf == false &&
        spacebar.gameObject.activeSelf == false &&
        R.gameObject.activeSelf == false &&
        B.gameObject.activeSelf == false &&
        colon.gameObject.activeSelf == false &&
        at.gameObject.activeSelf == false &&
        G.gameObject.activeSelf == false &&
        K.gameObject.activeSelf == false &&
        pound.gameObject.activeSelf == false &&
        E.gameObject.activeSelf == false &&
        O.gameObject.activeSelf == false &&
        nine.gameObject.activeSelf == false &&
        greaterthan.gameObject.activeSelf == false &&
        tab.gameObject.activeSelf == false &&
        W.gameObject.activeSelf == false &&
        underscore.gameObject.activeSelf == false &&
        V.gameObject.activeSelf == false &&
        M.gameObject.activeSelf == false &&
        pipe.gameObject.activeSelf == false &&
        U.gameObject.activeSelf == false &&
        J.gameObject.activeSelf == false){
            Panel.gameObject.SetActive(true);
        }
    }

}