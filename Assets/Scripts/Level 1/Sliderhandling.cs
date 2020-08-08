using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderhandling : MonoBehaviour {
    public Slider Main;
    public InclinationOFSlop SlopProperty;
    int Lastvalue = 0;
    // Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Main.value!=Lastvalue)
        {
            int temp =(int) Main.value - Lastvalue;
            if(temp>0)
            {
                SlopProperty.IncSlop();
            }
            else { SlopProperty.DecSlop(); }
            Lastvalue =(int) Main.value;
        
        }
	}

}
