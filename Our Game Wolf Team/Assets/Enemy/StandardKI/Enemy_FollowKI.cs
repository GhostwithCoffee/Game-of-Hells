using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_FollowKI : MonoBehaviour
{

    private Transform player;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        //Setting the player object, that the enemy is following
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //goes to the position of the player.
        Vector3 positionPlayer = player.position;
        transform.position = Vector3.MoveTowards(transform.position, positionPlayer, speed * Time.deltaTime);
    }
}
