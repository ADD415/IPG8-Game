using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseActivation : MonoBehaviour
{

    public SpiritSpawn spirit;

    void Start()
    {
       GetComponent<CaseMovement>().enabled = false;
       GetComponent<Rigidbody2D>().isKinematic = true;
    }


    void Update()
    {
            //Stop moving as the case.
            if (Input.GetKey(KeyCode.G))
            {
                GetComponent<CaseMovement>().enabled = false;
                GetComponent<CaseActivation>().enabled = false;
                GetComponent<Rigidbody2D>().isKinematic = true;
            }
        
    }

    public void CaseActivate()
    {
        GetComponent<CaseMovement>().enabled = true;
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<CaseActivation>().enabled = true;
    }

    public void CaseDeActivate()
    {
        GetComponent<CaseMovement>().enabled = true;
    }

}
