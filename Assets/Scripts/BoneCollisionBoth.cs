using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneCollisionBoth : MonoBehaviour
{

    public Spawner spawner;

    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
          

            case "Leg":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerBothArmsLeg();
                Spawner.value = 8;
                break;

            case "Leg2":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerFullFirst();
                Spawner.value = 10;
                break;

            case "Arm":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerBothLegsArm();
                Spawner.value = 9;
                break;

            case "Arm2":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerFull();
                Spawner.value = 10;
                break;


        }
    }


}
