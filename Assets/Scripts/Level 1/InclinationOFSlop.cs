using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InclinationOFSlop : MonoBehaviour {
    public GameObject Slop;
    public Text Angle;
    public List<float> Scales;
    public static float Deg;
   public List<float> Degrees;
    private int INDEX;
	// Use this for initialization
	void Start () {
        INDEX = 0;
        Vector3 Intial=new Vector3 (1,Scales[0],1);
        Slop.transform.localScale=Intial;
        Angle.text = Degrees[0].ToString();
        Deg = Degrees[0];


	}
	
	// Update is called once per frame
	void Update () {

       

		
	}
    public void IncSlop()
    {
        if(INDEX!=Scales.Count-1)
        {
            INDEX++;
        }
        Angle.text = Degrees[INDEX].ToString();
        Vector3 NewScale=new Vector3(1,Scales[INDEX],1);
        Slop.transform.localScale = NewScale;
        Deg = Degrees[INDEX];
       
    }
    public void DecSlop()
    {
        if (INDEX != 0)
        {
            INDEX--;
        }
        Angle.text = Degrees[INDEX].ToString();
        Vector3 NewScale = new Vector3(1, Scales[INDEX], 1);
        Slop.transform.localScale = NewScale;
        Deg = Degrees[INDEX];
    }
   

}
