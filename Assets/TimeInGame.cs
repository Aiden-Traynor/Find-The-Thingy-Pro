using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeInGame : MonoBehaviour
{

  public float TimeInMenu;
  public float TotalTime;
  public float BestTime;
  //public float Time = Time2;
  public static TimeInGame instance;
//To undo the errors, get rid of the 2s and comment the 3 lines below this....I brokeeded the game
//public int TimeInMenu2 = TimeInMenu;
//public int TotalTime2 = TotalTime;
//public int BestTime2 = BestTime;

void Awake(){
  if(instance == null){
    instance = this;
  }
else{
Destroy(gameObject);
}
DontDestroyOnLoad(this);
}
    // Start is called before the first frame update
    void Start()
    {

        //TotalTime2 = 0;
        //TimeInMenu2 = 0;
      //  BestTime2 = TotalTime;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void reset(){
  //  TimeInMenu2 = 0;
    //TotalTime2 = 0;

    }
    public void StartTimer(){
      TimeInMenu/*2*/ = Time.timeSinceLevelLoad;
    }

    public void UpdateTime(){
      TotalTime/*2*/ += Time.timeSinceLevelLoad;

    }
    //public void Time(){
      //Time2 = Math.Floor();
    

}
