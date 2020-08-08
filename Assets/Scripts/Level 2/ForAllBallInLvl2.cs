using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForAllBallInLvl2 : MonoBehaviour {

    public List<GameObject> Balls;
    public List<Transform> incLocs;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void reset()
    {
        for(int i=0;i<Balls.Count;i++)
        {
            Balls[i].transform.position = incLocs[i].position;
        }
    }
}
