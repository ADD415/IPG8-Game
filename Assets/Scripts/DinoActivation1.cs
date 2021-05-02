using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoActivation1 : MonoBehaviour
{
    void Start()
    {
        GetComponent<DinoMovemnt>().enabled = false;
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.G))
        {
            GetComponent<DinoMovemnt>().enabled = false;
            GetComponent<DinoActivation1>().enabled = false;
            GetComponent<Rigidbody2D>().isKinematic = true;

        }


    }


    public void DinoActivate()
    {
        GetComponent<DinoMovemnt>().enabled = true;
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<DinoActivation1>().enabled = true;
    }
}
