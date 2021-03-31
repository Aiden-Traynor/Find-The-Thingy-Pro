using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreCalculator : MonoBehaviour
{
public float highScore; /* this will store all time high score */
public float currentScore; /* this will store the current score and compare it against the all time high score */
public float coinWeight; 
public float timeWeight;
    // Start is called before the first frame update
    void Start()

    {
DontDestroyOnLoad(this);
	highScore = 0;
	currentScore = 0;
	coinWeight = 1; /* change the 1 to whatever you want to weight coins with */
timeWeight = 1; /* change the 1 to whatever you want to weight time with, keep in mind big time = bad! */
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void CalculateScore(int coins, float time) 
{
/* README we’ll say each coin is worth 100 points and each second is worth -1 point */
	/* README keep all operations (=,+,-,*), changing variable names if necessary */

	currentScore = coins * 100 * coinWeight - time * timeWeight;

	//this if statement updates the high score if your current score is the best
	if(currentScore > highScore) 
	{
		highScore = currentScore;
	}
}

}
