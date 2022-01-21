using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayScript : MonoBehaviour

{
  public float TotalTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateTime(){
          TotalTime/*2*/ += Time.timeSinceLevelLoad;
        }

    public void Replay()
    {
      SceneManager.LoadScene("Find The Thingy");
    }
}
