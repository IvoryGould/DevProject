using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISight : MonoBehaviour {

    RaycastHit hit;
    float range = 30;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 30;
        Debug.DrawRay(transform.position, forward, Color.red);

        if (Physics.Raycast(transform.position, forward, out hit, range)) {
            if (hit.collider.tag == "Player") {
                print(hit.collider.name);
            }
        }
	}
}
