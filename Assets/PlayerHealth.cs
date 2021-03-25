using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    FindTheThingyMoveScript bms;
    public int health;
    int maxHealth;
    public bool dead;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        bms = GetComponent<FindTheThingyMoveScript>();
        health = 3;
        maxHealth = 3;
        t.text = "health: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "health: " + health;

    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("enemy"))
        {
            if (health > 0)
            {
                health = health - 1;
            }
            if (health == 0)
            {
                dead = true;
                //bms.Die();
            }
        }
    }

    public void Hit(int damage)
    {
        if (health <= damage)
        {
                //bms.Die();


            health = 0;
        }
        else
        {
            health = health - damage;
        }
    }

    public void Reset()
    {
        health = maxHealth;
        dead = false;
    }
}
