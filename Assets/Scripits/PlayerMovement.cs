using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    float playerSpeed = 3;
    float playerRotationSpeed = 5;
    public GameObject fpsCamera;
    public int num;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        PlayerUpdate();

    }

    private void PlayerUpdate() {

        float currentSpeed = 0;
        float jumpHeight = 0;

        if (Input.GetKey(KeyCode.W) == true) {
            currentSpeed = playerSpeed * Time.deltaTime;
            transform.Translate(0, 0, currentSpeed);
            if (Input.GetKey(KeyCode.LeftShift) == true) {
                transform.Translate(0, 0, (currentSpeed * 2));
            }
        }

        if (Input.GetKey(KeyCode.S) == true) {
            currentSpeed = -playerSpeed * Time.deltaTime;
            transform.Translate(0, 0, currentSpeed);
        }

        if (Input.GetKey(KeyCode.D) == true) {
            currentSpeed = playerSpeed * Time.deltaTime;
            transform.Translate(currentSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) == true) {
            currentSpeed = -playerSpeed * Time.deltaTime;
            transform.Translate(currentSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) == true) {
            jumpHeight = 2 + playerSpeed * Time.deltaTime;
            transform.Translate(0, jumpHeight, 0);
        }

        if (Input.GetKeyDown(KeyCode.T) == true) {

        }



        float rotation = Input.GetAxis("Mouse X") * playerRotationSpeed;
        //rotation *= Time.deltaTime;
        transform.Rotate(0, rotation, 0);

    }



}
