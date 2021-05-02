using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bones : MonoBehaviour
{
    public GameObject Spine;
    public GameObject Ribs;
    public GameObject Leg;
    public GameObject Leg2;
    public GameObject Arm;
    public GameObject Arm2;
    public Spawner spawner;

    public void Start()
    {
      

       switch(Spawner.value)
        {
            case 2:
                Destroy(Spine);
                break;

            case 3:
                Destroy(Ribs);
                Destroy(Spine);
                break;

            case 4:
                Destroy(Ribs);
                Destroy(Spine);
                Destroy(Arm); 
                break;

            case 5:
                Destroy(Ribs);
                Destroy(Spine);
                Destroy(Arm); 
                Destroy(Arm2); 
                break;

            case 6:
                Destroy(Ribs);
                Destroy(Spine);
                Destroy(Leg); 
                break;

            case 7:
                Destroy(Ribs);
                Destroy(Spine);
                Destroy(Leg);
                Destroy(Leg2);
                break;

            case 8:
                Destroy(Ribs);
                Destroy(Spine);
                Destroy(Leg);
                Destroy(Arm); 
                Destroy(Arm2); 
                break;

            case 9:
                Destroy(Ribs);
                Destroy(Spine);
                Destroy(Leg);
                Destroy(Leg2);
                Destroy(Arm); 
                break;

            case 10:
                Destroy(Ribs);
                Destroy(Spine);
                Destroy(Leg);
                Destroy(Leg2);
                Destroy(Arm); 
                Destroy(Arm2); 
                break;

        }

    }

}
