using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/* This script goes on your enemy object
 * What this script needs:
 *  for the enemy object
 *      a NavMeshAgent with the base offset set to whatever you want to make it fly high enough. The script will automatically take into account any changes.
 *      tagged as "enemy" if you want it to do damage to the player
 *
 *  nested underneath the enemy object:
 *      an object with a sphere collider with isTrigger checked and the AerialRange script attached - this is your enemy's range
 *      an object with a box or capsule collider with isTrigger checked and the AerialDive script attached - this is your enemy's dive range, I used a column directly underneath the enemy
 */
public class AerialEnemyAI : MonoBehaviour
{
    float offset;
    //this will speed up or slow down your dive and return
    public float diveSpeedMod = 5f;
    public bool engaged;
    NavMeshAgent nm;
    GameObject player;
    bool wandering;
    bool inRange;
    //this is how long the enemy will wait before diving again if you're still in range
    public float coolDown = 1f;
    public bool dive;
    bool diving;
    bool returning;
    bool wait = false;
    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        wandering = true;
        dive = false;
        engaged = false;
        diving = false;
        offset = nm.baseOffset;
    }

    // Update is called once per frame
    void Update()
    {
        if (returning)
        {
            //for this one I would play your normal flying animation

            nm.baseOffset += Time.deltaTime * nm.speed * diveSpeedMod;
            if (nm.baseOffset > offset)
            {
                nm.baseOffset = offset;
                returning = false;
                StartCoroutine(CoolDown());
            }
        }
        else if (!wait && dive && !player.GetComponent<PlayerHealth>().dead)
        {
            diving = true;
	    GetComponent<Animator>().SetBool("isAttacking", true);
            dive = false;
        }
        else if (diving)
        {
            //play your dive animation here! I would make sure it doesn't loop

            nm.baseOffset -= Time.deltaTime * nm.speed * diveSpeedMod;
            if (nm.baseOffset < 0)
            {
                nm.baseOffset = 0;
                diving = false;
                returning = true;
		GetComponent<Animator>().SetBool("isAttacking", false);
            }
        }
        else if (engaged && !player.GetComponent<PlayerHealth>().dead)
        {
            nm.SetDestination(player.transform.position);
        }
        else
        {
            Wander();
        }
    }

    void Wander()
    {
        if (!nm.hasPath)
        {
            nm.SetDestination(new Vector3(Random.Range(transform.position.x - 10, transform.position.x + 10), 1, Random.Range(transform.position.z - 10, transform.position.z + 10)));
        }
    }

    IEnumerator CoolDown()
    {
        wait = true;
        yield return new WaitForSeconds(coolDown);
        wait = false;
    }
}
