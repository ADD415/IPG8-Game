using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneCollisions : MonoBehaviour
{
    public Spawner spawner;

    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {

            case "Spine":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerSpine();
                Spawner.value = 2;
                break;

            case "Ribs":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerRibs();
                Spawner.value = 3;
                break;

            case "Leg":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerLegFirst();
                Spawner.value = 6;
                break;

            case "Leg2":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerBothLegsFirst();
                Spawner.value = 7;
                break;

            case "Arm":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerArmFirst();
                Spawner.value = 4;
                break;

            case "Arm2":
                Destroy(gameObject);
                Destroy(other.gameObject);
                spawner.spawnPlayerBothArmsFirst();
                Spawner.value = 5;
                break;


        }
    }
}
