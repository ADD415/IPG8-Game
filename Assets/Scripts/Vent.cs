using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent : MonoBehaviour
{

    public GameObject Vent1Button;
    public GameObject Vent2Button;

    void Start()
    {
        Vent1Button.SetActive(false);
        Vent2Button.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (Spawner.value == 4)
        {
            Vent1Button.SetActive(true);
        }
        else if (Spawner.value == 5)
        {
            Vent2Button.SetActive(true);
        }
      
    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        Vent1Button.SetActive(false);
        Vent2Button.SetActive(false);
    }


}
