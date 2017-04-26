using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharProgress : MonoBehaviour {

    public UIControl uiControl;

    public int Exp;
    public int Level;
    //public Text expText;
    //public Text LvText;

	void Start () {
        Exp = 0;
        Level = 1;
        Initialize();
	}
	

	void Update () {
        //Initialize();
        AddLevel();
    }

    public void AddExp() {
        Exp = Exp + 10;
        uiControl.expText.text = "Xp: " + Exp.ToString();
    }

    void AddLevel() {
        if (Exp == 100) {
            Level = Level + 1;
            Exp = 0;
            uiControl.LvText.text = "Lv: " + Level.ToString();
        }
    }

    void Initialize() {
        uiControl.expText.text += Exp.ToString();
        uiControl.LvText.text += Level.ToString();
    }
}
