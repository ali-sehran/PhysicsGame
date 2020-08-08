using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBehavior : MonoBehaviour {
    public GameObject Box;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 NewPos = new Vector3(Box.transform.position.x+1, Box.transform.position.y, Box.transform.position.z);
        transform.position = NewPos;
        
		
	}
}
