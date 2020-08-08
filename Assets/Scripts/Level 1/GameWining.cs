using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWining : MonoBehaviour {
    public GameObject Level;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        
        DataManager.ChangeGameState();
        Level.SetActive (false);
    }
}
