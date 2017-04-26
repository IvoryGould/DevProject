using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    CursorLockMode wantedMode;
    public bool lockActive = true;

    void Start() {
        if (lockActive == true){
            wantedMode = CursorLockMode.Locked;
        }
    }


    void Update() {

        SetCursorState();
        if (lockActive == false){
            wantedMode = CursorLockMode.None;
        }
        if (lockActive == true) {
            wantedMode = CursorLockMode.Locked;
        }
    }

    void SetCursorState() {

        Cursor.lockState = wantedMode;

    }
}
