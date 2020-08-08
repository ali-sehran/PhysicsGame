using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

	// Use this for initialization
    public Rigidbody2D Ob;
    public GameObject Obj;
    public Transform Location;
    public static Transform Pos;   
    
    void Awake()
    {
     
    }
    void Start () {
        Vector3 Loc = new Vector3(Location.position.x, Location.position.y, Location.position.z);
       try
       {
           Pos.position = Loc;
	
       }
        catch
       {
           print("Nothing");
       }
 }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ReloadballPostion ()
    {
        Ob.angularVelocity = 0;
        Ob.velocity = Vector3.zero;
       
        Obj.transform.position = Location.position;
    }
}
