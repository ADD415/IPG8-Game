using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReactivation : MonoBehaviour
{
    void Update()
    {
        // Stops you being the spirit.
        if (Input.GetKey(KeyCode.G))
        {
            Destroy(GameObject.Find("spirit(Clone)"));
            GetComponent<Player>().enabled = true;
            GetComponent<SpiritSpawn>().enabled = true;
            GetComponent<Rigidbody2D>().isKinematic = false;
            GetComponent<Collider2D>().enabled = true;

        }
    }
}
