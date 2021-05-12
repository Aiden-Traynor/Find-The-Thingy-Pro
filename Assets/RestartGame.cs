using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void restart(){
GameObject.FindGameObjectWithTag("Score And Time Calculator").GetComponent<TimeInGame>().reset();
	SceneManager.LoadScene("Find The Thingy");
}
}
