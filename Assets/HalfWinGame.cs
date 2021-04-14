using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Score And Time Calculator highScore;
public class HalfWinGame : MonoBehaviour
{
  HighScoreScript highScore;
  public string Level;
    // Start is called before the first frame update
    void Start()
    {
      // highScore = GameObject.FindGameObjectWithTag("ScoreAndTimeCalculator").GetComponent<HighScoreCalculator>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag.Equals("Player"))
      {
      /*  int Gold = other.gameObject.GetComponent<FindTheThingyMoveScript>().Gold;
		    float time = Time.timeSinceLevelLoad;
        highScore.CalculateScore(Gold, time);  /* replace highScore with your variable name, and CalculateScore with whatever you named your calculate function */

      //if (other.gameObject.GetComponent<FindTheThingyMoveScript>().Gold == 1)
    //  {

        SceneManager.LoadScene(Level);
      }
    }

}
