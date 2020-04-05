using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porter_Nordic : MonoBehaviour
{
    //Ports the player to the nordic hell
    void OnTriggerEnter2D(Collider2D playerCol)
    {
        if (playerCol.gameObject.name == "Player")
        {
            Debug.Log("Collision ist da.");
            SceneManager.LoadScene("NordicHell");
        }
    }
}
