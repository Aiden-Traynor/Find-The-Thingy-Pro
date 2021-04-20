using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This script goes on a child object nested underneath your enemy object
 * What this script needs:
 *  a sphere collider with isTrigger checked and the AerialRange script attached - this is your enemy's range
 *  make sure its nested directly underneath the object with the AerialEnemyAI script attached!
 */
public class AerialRange : MonoBehaviour
{
    public AerialEnemyAI aeai;
    // Start is called before the first frame update
    void Start()
    {
        aeai = transform.parent.gameObject.GetComponent<AerialEnemyAI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag.Equals("Player"))
        {
            aeai.engaged = true;
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag.Equals("Player"))
        {
            aeai.engaged = false;
        }
    }
}
