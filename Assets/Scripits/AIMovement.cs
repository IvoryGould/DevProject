using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour {

    public Transform goal;
    bool active = true;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        Movement();
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Movement() {
        while(active == true){
            goal.position = new Vector3(Random.Range(-3,3), 0, Random.Range(-3,3));
            yield return new WaitForSecondsRealtime(Random.Range(5, 20));
            
        }
    }
}
