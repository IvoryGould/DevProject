using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {

    public GameManager gameManager;

    public Text interactText;
    public Text expText;
    public Text LvText;
    public Image inventoryPanel;
    public Image objectInventory;
    public Image characterPanel;
    public Canvas worldUI;

    void Awake() {

    }

    void Start () {
        interactText.enabled = false;
        inventoryPanel.enabled = false;
        objectInventory.enabled = false;
        characterPanel.enabled = false;
        worldUI.enabled = true;
    }
	

	void Update () {
        InventoryCloseUpdate();
        InventoryOpenUpdate();
	}

    void InventoryCloseUpdate() {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            inventoryPanel.enabled = false;
            objectInventory.enabled = false;
            characterPanel.enabled = false;
            gameManager.lockActive = true;
        }
    }

    void InventoryOpenUpdate() {
        if (Input.GetKeyDown(KeyCode.Tab) && inventoryPanel.enabled == false && characterPanel == false) {
            inventoryPanel.enabled = true;
            characterPanel.enabled = true;
        }
    }
}
