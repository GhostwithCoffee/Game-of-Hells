using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Data : MonoBehaviour
{
    //The Class for the Player Data
    private static float health = 100;

    //health getter
    public static float getHealth()
    {
        return health;
    }

    //Sets the health
    public static void setHealth(float healthVar)
    {
        health += healthVar;
    }
}
