using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenBallChange : MonoBehaviour {

    public Sprite BurntWooden;
    public Sprite Normal;
    public GameObject WoodenBall;
    public float Intialradius;
    public static bool Trigger = false;
    public bool once = true;
    public float x, y, z;//0.301593
    // Use this for initialization
    void Start()
    {
        WoodenBall.GetComponent<CircleCollider2D>().radius = Intialradius;
        WoodenBall.GetComponent<SpriteRenderer>().sprite = Normal;
        transform.localScale = new Vector3(x, y, z);
        Trigger = false;
        once = true;
    }

    // Update is called once per frame
    void Update()

    {
        if (Trigger && once)
        {
            once = false;
            ChangeMyImage();
        }
    }
    public static void ChangeTrigger()
    {
        Trigger = true;
    }
    public void ChangeMyImage()
    {

        
        WoodenBall.GetComponent<SpriteRenderer>().sprite = BurntWooden;
        Vector3 scale = new Vector3(x - 0.301593f, y- 0.301593f, z - 0.301593f);
        WoodenBall.GetComponent<CircleCollider2D>().radius = Intialradius + 1.5797958f;
        transform.localScale = scale;
    }
    public void Restart()
    {
        Start();
    }
}
