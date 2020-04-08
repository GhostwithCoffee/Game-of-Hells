using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_FollowKI : MonoBehaviour
{

    private GameObject player;
    public float speed = 25;
    // Start is called before the first frame update
    void Start()
    {
        //Setting the player object, that the enemy is following
        if (player == null)
        {
            player = GameObject.Find("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //goes to the position of the player.
        Vector3 positionPlayer = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, positionPlayer, speed * Time.deltaTime);
    }
}
