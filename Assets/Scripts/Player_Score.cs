using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{

    public UIManager uimanager;

    void OnTriggerEnter2D (Collider2D trig)
    {

        if (trig.gameObject.CompareTag("Milk"))
        {
            uimanager.lifeGained();
            uimanager.Score_increase();
            Destroy(trig.gameObject);
        }

        if (trig.gameObject.CompareTag("Bone"))
        {
            uimanager.Score_increase();
        }

        if (trig.gameObject.CompareTag("Death"))
        {
            uimanager.Score_Decrease();

        }

    }


}  
