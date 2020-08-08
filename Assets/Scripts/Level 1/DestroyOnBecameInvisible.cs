using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnBecameInvisible : MonoBehaviour {
    public Rigidbody2D Ob;
    public GameObject Obj;
    public Transform Location;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnBecameInvisible()
    {
        Ob.angularVelocity = 0;
        Ob.velocity = Vector3.zero;

        Obj.transform.position = Location.position;
    }
}
