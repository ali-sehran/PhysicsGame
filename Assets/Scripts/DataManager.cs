using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {

    public static DataManager instance;
    public static bool GameWin;
    int Index = 0;
    public Transform Intial;
    public float DifferenceInX;
    public List<GameObject> Levels;
    public Camera Main;
    void Awake()
    {
        GameWin = false;
        instance = this;
        Index = 0;
        Levels[0].SetActive(true);
    }

    
	// Use this for initialization
	void Start () {
        Levels[0].SetActive(true);
        Vector3 Pos = new Vector3(Intial.transform.position.x , Intial.transform.position.y, Intial.transform.position.z);
        Intial.position = Pos;
        Instantiate(Levels[0],Pos , Quaternion.identity);
        Levels[0].SetActive(true);
        Index = 0;
		for(int i=1;i<Levels.Count;i++)
        {
            Levels[i].SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
       if(GameWin)
       {
           print(Index);
           Levels[Index].SetActive(false);
           Index++;

           GameWin = false;
           Vector3 Pos = new Vector3(Intial.transform.position.x+DifferenceInX, Intial.transform.position.y, Intial.transform.position.z);
           Intial.position = Pos;
           if (Index < Levels.Count)
           {
               Levels[Index].SetActive(true);
           
               Instantiate(Levels[Index], Pos, Quaternion.identity);
               CameraMove();
               Main.transform.position = Vector3.Lerp(Main.transform.position, new Vector3(Pos.x,Pos.y,-10),2f);
           }


             
       }
		
	}
    
    void  CameraMove()
    {

        Vector3 Rotation = new Vector3(0, 0, 360);
        Main.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(Vector3.zero),Quaternion.Euler (Rotation), 2f);
        
    }
   
    public static void ChangeGameState()
    {
       
         GameWin = true;
        
    }

}
