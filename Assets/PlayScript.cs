using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour
{
  public GameObject menuCamera; /* this will be the Camera object that looks at the main menu */
  public GameObject playerCamera; /* this will be the Camera object that looks at the player */

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BeginGame()
    {
      //GameObject.FindGameObjectWithTag("Main Menu Music").GetComponent<AudioSource>().Stop();
      GameObject.FindGameObjectWithTag("FTTP Music").GetComponent<AudioSource>().Play();

	  menuCamera.SetActive(false);
	  playerCamera.SetActive(true);
}

}
