using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This script goes on a child object nested underneath your enemy object
 * What this script needs:
 *  a box or capsule collider with isTrigger checked and the AerialDive script attached - this is your enemy's dive range
 *        I used a column directly underneath the enemy 
 *  make sure its nested directly underneath the object with the AerialEnemyAI script attached!
 */
public class AerialDive : MonoBehaviour
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
            aeai.dive = true;
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag.Equals("Player"))
        {
            aeai.dive = false;
        }
    }
}
