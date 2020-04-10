using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_StandardDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Player_Data.setHealth(-1);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Player_Data.setHealth(-0.5f);
        }
    }

}
