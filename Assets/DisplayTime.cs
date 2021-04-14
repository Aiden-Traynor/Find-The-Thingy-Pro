using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{

  Text t;
  TimeInGame tig;
    // Start is called before the first frame update
    void Start()
    {
        tig = GameObject.FindGameObjectWithTag("Score And Time Calculator").GetComponent<TimeInGame>();
        t = GetComponent <Text>();
    }

    // Update is called once per frame
    void Update()
    {

      t.text = "Time: " + (Time.timeSinceLevelLoad - tig.TimeInMenu);
    }
}
