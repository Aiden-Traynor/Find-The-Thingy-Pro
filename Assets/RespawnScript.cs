﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{

  public Vector3 respawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other) {
	  if(other.gameObject.tag.Equals("Player") || other.gameObject.tag.Equals("enemy")) {
		other.gameObject.transform.position = respawn;
	}
}

}
