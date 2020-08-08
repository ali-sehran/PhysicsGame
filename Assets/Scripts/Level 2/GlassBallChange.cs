using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBallChange : MonoBehaviour {
    public Sprite MeltedGlass;
    public Sprite Normal;
    public float Intialradius;
    public GameObject GlassBall;
    float radius = 0.91f;
    public static bool Trigger = false;
    public bool once = true;
    public float x, y, z;
   
	// Use this for initialization
    void Start()
    {
        GlassBall.GetComponent<CircleCollider2D>().radius = Intialradius;
        GlassBall.GetComponent<SpriteRenderer>().sprite = Normal;
        transform.localScale = new Vector3(x, y, z);
        Trigger = false;
        once = true;
    }
	// Update is called once per frame
	void Update () {

        if (Trigger && once)
        {
            once = false;
            ChangeMyImage();
        }
	}
    public void ChangeMyImage()
    {

       
       GlassBall.GetComponent<SpriteRenderer>().sprite = MeltedGlass;
       Vector3 scale = new Vector3(x + 0.44958928f, y + 0.44958928f, z + 0.44958928f);
       GlassBall.GetComponent<CircleCollider2D>().radius = radius;
       transform.localScale = scale;
       
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
