using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porter_Classic : MonoBehaviour
{
    //Ports the player to the classic hell
    void OnTriggerEnter2D(Collider2D playerCol)
    {
        if (playerCol.gameObject.name == "Player")
        {
            Debug.Log("Collision ist da.");
            SceneManager.LoadScene("ClassicHell");
        }
    }
}
