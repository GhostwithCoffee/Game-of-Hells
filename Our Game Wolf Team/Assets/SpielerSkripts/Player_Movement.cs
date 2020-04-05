using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovmentPlayer();
    }

    // Movment method for the player
    void MovmentPlayer()
    {
        Vector3 newPos = transform.position;
        if (Input.GetKey("w"))
        {
            newPos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            newPos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            newPos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            newPos.x += speed * Time.deltaTime;
        }
        transform.position = Vector3.MoveTowards(transform.position, newPos, speed * Time.deltaTime); ;
    }

}
