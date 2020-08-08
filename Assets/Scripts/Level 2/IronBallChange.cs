using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBallChange : MonoBehaviour {
    
    public GameObject IronBall;
    public Transform Trans;
    public float x, y, z;
    
    public float Multi;
    public static bool Trigger = false;
    public bool once = true;
   
	// Use this for initialization
  
	void Start () {
      
        IronBall.transform.localScale = new Vector3(x,y,z);
        Trigger = false;
        once = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Trigger && once)
        {
            once = false;
            ChangeMyImage();
        }
	}
     public  void ChangeMyImage()
    {
          
        
        Vector3 Local = new Vector3(IronBall.transform.localScale.x * Multi, IronBall.transform.localScale.y * Multi, IronBall.transform.localScale.z * Multi);
         transform.localScale= Vector3.Lerp(IronBall.transform.localScale,Local,1.6f);
    }
    

    public static void ChangeTrigger()
     {
         Trigger = true;
     }
    public void Restart()
    {
        Start();
    }
}
