using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragScript : MonoBehaviour {
     bool DragOrNot;
    public Rigidbody2D Obj;
    public Collider2D Obj2;
    
    public List<GameObject>location;
    public Transform IntialPosition;
   
      bool   Stable = false;
     bool  CheckItBool = true;
    
	// Use this for initialization
	 void  Start () {
         DragOrNot = false;
         CheckItBool = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(DragOrNot)
        {
            Obj.angularVelocity = 0;
            Obj.velocity = Vector3.zero;
            Vector3 Pos=new Vector3 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
            transform.position = Pos;
        }
        Invoke("ChngMystate",0.3f);
	}

    void OnMouseDown()
    {
        Obj2.GetComponent<CircleCollider2D>().enabled = false;
        CheckItBool = true;
        Obj.isKinematic = true;
        DragOrNot = true;
        Stable = false;
    }
    void OnMouseUp()
    {
        Obj2.GetComponent<CircleCollider2D>().enabled = true;
        Obj2.isTrigger = true;
        Obj.isKinematic = true;
        DragOrNot = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (CheckIt(other))
        {
            Obj2.transform.position = other.transform.position;
           
            Stable = true;
            CheckItBool = false;
        }
        Obj.isKinematic =true;
        DragOrNot = false;
    }
    bool CheckIt(Collider2D other)
    { 
        if("Loc1"==other.tag|| "Loc2"==other.tag||"Loc3"==other.tag)
        {
            return true;
        }
        return false;
    }
    void ChngMystate()
    {
        if (Stable == false && CheckItBool == true && DragOrNot == false)
        {
            Obj.isKinematic = false;
            Obj2.isTrigger = false;
            Obj.angularVelocity = 0;
            Obj.velocity = Vector3.zero;
            Obj.transform.position = IntialPosition.position;
        }
    }
    public  void Restart()
    {
        Start();
       
    }
 
}