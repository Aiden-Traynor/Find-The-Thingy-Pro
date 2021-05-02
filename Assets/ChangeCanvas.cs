using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCanvas : MonoBehaviour
{
  public GameObject HTP;
  public GameObject MM;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SwitchCanvas() {
	  HTP.SetActive(false);
	  MM.SetActive(true);
}

}
