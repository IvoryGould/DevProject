using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCamera : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
        float cameraRotationSpeed = 5;
        float rotation = Input.GetAxis("Mouse Y") * cameraRotationSpeed;
        transform.Rotate(-rotation, 0, 0);
    }
}

