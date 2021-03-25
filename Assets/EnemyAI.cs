using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/* To use this script
 *     your enemy needs: a NavMeshAgent component, a collider, a trigger collider (its "range"), and to be tagged as "enemy"
 *     your terrain needs: to be baked as a NavMesh
 *          go to the windows tab, then go down to Navigation, then find the button to "bake" your NavMesh
 */
public class EnemyAI : MonoBehaviour
{
    bool engaged;
    NavMeshAgent nm;
    public GameObject player;
    bool wandering;
    bool inRange;
    float coolDown;
    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        wandering = false;
    }

    // Update is called once per frame
    void Update()
    { 
        if (InRange())
        {
            Attack();
        }
        if (engaged && !player.GetComponent<PlayerHealth>().dead)
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
            nm.SetDestination(new Vector3(Random.Range(5, 95), 1, Random.Range(5, 95)));
        }
    }

    IEnumerator Attack()
    {
        inRange = false;
        nm.SetDestination(player.transform.position);
        nm.speed = 5f;
        yield return new WaitForSeconds(0.1f);
        nm.SetDestination(transform.position - new Vector3(0.5f, 1, 0.5f));
        nm.speed = 2;
        yield return new WaitForSeconds(coolDown);
    }

    bool InRange()
    {
       return (((transform.position - player.transform.position).magnitude < 0.5) && nm.speed < 5);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag.Equals("Player"))
        {
            engaged = true;
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag.Equals("Player"))
        {
            engaged = false;
        }
    }
}
