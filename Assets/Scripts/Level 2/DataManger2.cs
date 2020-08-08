using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManger2 : MonoBehaviour
{
    static int counter = 0;
    public List<Rigidbody2D> Balls;
    public List<GameObject> BallObj;
    public List<Rigidbody2D> BallRigid;
    public List<Transform> AccessAbleLocations;
    public List<GameObject> AccessAbleLoc;
    public List<Collider2D> Ballss;
    bool PushOnce = true;
    int index = -1;
    static bool IsThereGlass = false;
    char WHOMTOTRIGGER;

    public bool Game = false;
    // Use this for initialization
    void Start()
    {
        IsThereGlass = false;
        index = -1;
        PushOnce = true;
        counter = 0;
        for (int i = 0; i < AccessAbleLoc.Count; i++)
        {
            AccessAbleLoc[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        IncCounter();
        if (counter == 3)
        {
            for (int i = 0; i < AccessAbleLoc.Count; i++)
            {
                AccessAbleLoc[i].SetActive(false);
            }
            for (int i = 0; i < Balls.Count; i++)
            {
                Balls[i].isKinematic = false;
                Ballss[i].isTrigger = false;
            }
            if (index != -1)
            {
                if((BallObj[index].tag=="GlassBall" || BallObj[index].tag=="Wooden") && WHOMTOTRIGGER=='I')
                {
                    IsThereGlass = true;
                    Invoke("PushBall", 1.5f);

                }
            }
            if(WHOMTOTRIGGER=='I')
            {
                IronBallChange.ChangeTrigger();
            }
            else if (WHOMTOTRIGGER == 'W')
            {
                WoodenBallChange.ChangeTrigger();
            }
            else if (WHOMTOTRIGGER == 'G')
            {
                GlassBallChange.ChangeTrigger();
            }
        }    
    }
    void PushBall()
    {
        if (PushOnce && IsThereGlass)
        {
            Vector2 Push = new Vector2(1, 0);

            BallRigid[index].velocity = Push;
            //        print(BallObj[index].tag);
            PushOnce = false;
            //      print(index);


        }
    }
    void ChangeGameState()
    {
        if (Game == false)
        {
            Game = true;
        }
        else
        {
            Game = false;
        }
    }
    public void IncCounter()
    {
        counter = CheckHowManyAreLocated();
 
    }
  
    public void Restart()
    {
        Start();
       

    }
    static void ChangeModeToIron()
    {
        IsThereGlass = true;
    }
    public int CheckHowManyAreLocated()
    {
        int num = 0;
        for (int i = 0; i < BallObj.Count; i++)
        {
            for(int j=0;j<AccessAbleLocations.Count;j++)
            {
                if (BallObj[i].transform.position == AccessAbleLoc[j].transform.position)
                {
                    if(AccessAbleLoc[j].tag=="Loc2")
                    {
                        //print(i);
                        index = i;
                    }
                    else if (AccessAbleLoc[j].tag == "Loc3")
                    {
                        if (BallObj[i].tag == "Iron")
                        {
                            WHOMTOTRIGGER = 'I';
                        }
                        else if (BallObj[i].tag == "GlassBall")
                        {
                            WHOMTOTRIGGER = 'G';
                        }
                        else if (BallObj[i].tag == "Wooden")
                        {
                            WHOMTOTRIGGER = 'W';
                        }
                    }
                    num++;
                }
            }
        }
      
        return num;
    }
}

   
