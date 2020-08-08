using UnityEngine;
using UnityEngine.UI;

public class MainSpinalCord : MonoBehaviour
{
    int Distance = 20;
    public GameObject Objec;
    bool StartFollowThePointer = false;
    public Rigidbody2D rb;
    public  float intialXPos;
    public float ForceMultiple;
    public Text ForceAmount;
    int ForceAmountInt;
    public Text WorkDone;
    static float Number;
	// Use this for initialization
	void Start () {
        
	}
   
	
	// Update is called once per frame
	void Update () {


        
        if(StartFollowThePointer)
        {
            Vector3 xPOs = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 Post = new Vector3(Mathf.Clamp(xPOs.x, 5.85f, 8.28f), Objec.transform.position.y, Objec.transform.position.z);
            rb.position = Post;
        }
        ForceAmountInt = (int)((Objec.transform.position.x - intialXPos)*ForceMultiple);
        ForceAmount.text = ForceAmountInt.ToString();


	}
    void OnMouseDown()
    {
        StartFollowThePointer = true;
       rb.isKinematic = true;

    }
    void OnMouseUp()
    {
        StartFollowThePointer = false;
        rb.isKinematic = false;
        float work=0f;
      
        work = ForceAmountInt * Distance ;
        work = work * Mathf.Cos(InclinationOFSlop.Deg* Mathf.PI/180);
        print(Mathf.Cos(InclinationOFSlop.Deg * Mathf.PI / 180) + " " + InclinationOFSlop.Deg + "\n");
       
        work =Mathf.Round(work * 10f) / 10f;
        WorkDone.text = work.ToString();


    } 
}
