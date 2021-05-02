using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritSpawn : MonoBehaviour
{
    public Player Spawnloc;
    public SpiritMovement Spirit;

    void Update()
    {
        //spawns the spirit adn de-activates the player.
        if (Input.GetKey(KeyCode.S))
        {
            spawnSpirit();
            GetComponent<Player>().enabled = false;
            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<SpiritSpawn>().enabled = false;    
            GetComponent<Collider2D>().enabled = false;
          
        }

        
    }

    public void spawnSpirit()
    {
        SpiritMovement SpiritClone = Instantiate(Spirit);

        SpiritClone.transform.position = Spawnloc.transform.position;

        SpiritClone.gameObject.SetActive(true);
    }

}
