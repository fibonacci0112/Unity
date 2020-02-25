using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    Rigidbody rb;
    float pnoise;
    float searchspeed;
    float attackspeed;
    float damagedist;
    float incr;
    int walking;
    bool seenyou;
    MeshCollider sight;
    Collider player;

    void Start()
    {
        damagedist = 1;
        searchspeed = 15;
        attackspeed = 4.5f;
        rb = GetComponent<Rigidbody>();
        incr = (int)(Random.value * 1000);
        sight = GetComponent<MeshCollider>();
    }

    void Update()
    {
        if (!seenyou)
        {
            Search();
        }
        else
        {
            Attack();
        }
    }

    void Search()
    {
        if (Random.value > 0.7)
        {
            walking = 1;
        }
        else
        {
            walking = 0;
        }
        rb.AddRelativeForce(walking * searchspeed, 0, 0);
        transform.Rotate(new Vector3(0, (Mathf.PerlinNoise((incr + 500) / 1000, (incr + 400) / 1000) - 0.5f), 0));
        incr += 1;
    }

    void Attack()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * attackspeed * Time.deltaTime;

        if (Vector3.Distance(transform.position, player.transform.position) <= damagedist)
        {
            player.gameObject.GetComponent<PlayerHealth>().health -= 3;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            seenyou = true;
            player = other;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            seenyou = false;
            player = null;
        }
    }
}
