using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeInGame : MonoBehaviour
{

  public float TimeInMenu;
  public float TotalTime;
  public float BestTime;
  public static TimeInGame instance;
//To undo the errors, get rid of the 2s and comment the 3 lines below this
int TimeInMenu2 = integer(TimeInMenu);
int TotalTime2 = integer(TotalTime);
int BestTime2 = integer(BestTime);

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

        TotalTime2 = 0;
        TimeInMenu2 = 0;
        BestTime2 = TotalTime;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void reset(){
    TimeInMenu2 = 0;
    TotalTime2 = 0;

    }
    public void StartTimer(){
      TimeInMenu2 = Time.timeSinceLevelLoad;
    }
    public void UpdateTime(){
      TotalTime2 += Time.timeSinceLevelLoad;
    }
}
