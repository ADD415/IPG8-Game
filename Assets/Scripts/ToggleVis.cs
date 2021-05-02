using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVis : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;


    public void Start()
    {
    }

    public void Update()
    {
        //start
        if (Spawner.value <= 2 )
        {
            button1.SetActive(false);
            button2.SetActive(false);          
        }
        //When they have ribs 
        else if (Spawner.value <= 4 )
        {
            button1.SetActive(false);
            button2.SetActive(true);
        }
        //When they have arms 
        else if (Spawner.value >= 5)
        {
            button1.SetActive(true);
            button2.SetActive(true);
        }
    }

}
