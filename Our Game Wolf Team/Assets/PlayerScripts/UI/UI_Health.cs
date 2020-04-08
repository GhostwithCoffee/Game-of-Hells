using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Health : MonoBehaviour
{
    public Text healthText;

    // Update is called once per frame
    void Update()
    {
        healthText.text = "" + Player_Data.getHealth();
    }
}
