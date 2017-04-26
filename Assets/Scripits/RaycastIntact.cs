using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastIntact : MonoBehaviour {
    RaycastHit hit;
    float range = 2;

    public UIControl uicontrol;
    public GameManager gameManager;

    void Awake() {

    }

    void Start() {

    }

    void Update() {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 2;
        Debug.DrawRay(transform.position, forward, Color.green);

        if (uicontrol.inventoryPanel.enabled == false) {
            if (Physics.Raycast(transform.position, forward, out hit, range)){
                if (hit.collider.tag == "Chest"){
                    uicontrol.interactText.enabled = true;
                    if (Input.GetKeyDown(KeyCode.E) == true){
                        gameManager.lockActive = false;
                        uicontrol.inventoryPanel.enabled = true;
                        uicontrol.objectInventory.enabled = true;
                        uicontrol.characterPanel.enabled = true;
                    }
                }
                if (hit.collider.tag == "Door"){
                    uicontrol.interactText.enabled = true;
                    if (Input.GetKeyDown(KeyCode.E) == true){
                        print(hit.collider.name);
                    }
                }
            } else {
                uicontrol.interactText.enabled = false;
            }
        }
    }
}