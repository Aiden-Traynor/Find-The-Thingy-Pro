using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeInGame : MonoBehaviour
{

  public float TimeInMenu;
  public float TotalTime;
  public float BestTime;
  public static TimeInGame instance;

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
        
        TotalTime = 0;
        TimeInMenu = 0;
        BestTime = TotalTime;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void reset(){
    TimeInMenu = 0;
    TotalTime = 0;
    
    }
    public void StartTimer(){
      TimeInMenu = Time.timeSinceLevelLoad;
    }
    public void UpdateTime(){
      TotalTime += Time.timeSinceLevelLoad;
    }
}
