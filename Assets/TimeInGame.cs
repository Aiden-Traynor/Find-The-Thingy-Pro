using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeInGame : MonoBehaviour
{

  public float TimeInMenu;
  public float TotalTime;
  public float BestTime;
  

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        TotalTime = 0;
        TimeInMenu = 0;
        BestTime = TotalTime;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartTimer(){
      TimeInMenu = Time.timeSinceLevelLoad;
    }
    public void UpdateTime(){
      TotalTime += Time.timeSinceLevelLoad;
    }
}
