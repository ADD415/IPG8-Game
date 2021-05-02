using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Player playerTemplate;
    public Player playerDamaged;
    public Player playerSpine;
    public Player playerRibs;
    public Player playerArm;
    public Player playerArmFirst;
    public Player playerBothArms;
    public Player playerBothArmsFirst;
    public Player playerLeg;
    public Player playerLegFirst;
    public Player playerBothLegs;
    public Player playerBothLegsFirst;
    public Player playerFull;
    public Player playerFullFirst;
    public Player playerBothArmsLeg;
    public Player playerBothLegsArm;
    static public int value = 1;

    void Start()
    {

        switch (Spawner.value)
        {
            case 1:
                spawnPlayer();
                break;

            case 2:
                spawnPlayerSpine();
                break;

            case 3:
                spawnPlayerRibs();
                break;

            case 4:
                spawnPlayerArm();
                break;

            case 5:
                spawnPlayerBothArms();
                break;

            case 6:
                spawnPlayerLeg();
                break;

            case 7:
                spawnPlayerBothLegs();
                break;

            case 8:
                spawnPlayerBothArmsLeg();
                break;
               
            case 9:
                spawnPlayerBothLegsArm();
                break;

            case 10:
                spawnPlayerFull();
                break;

        }
                
    }

  
    public void spawnPlayer()
    {
        Player playerClone = Instantiate(playerTemplate);

        playerClone.transform.position = transform.position;   

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerDamaged()
    {
        Player playerClone = Instantiate(playerDamaged);

        playerClone.transform.position = transform.position;

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerSpine()
    {
        Player playerClone = Instantiate(playerSpine);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerRibs()
    {
        Player playerClone = Instantiate(playerRibs);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerArm()
    {
        Player playerClone = Instantiate(playerArm);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerArmFirst()
    {
        Player playerClone = Instantiate(playerArmFirst);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerBothArms()
    {
        Player playerClone = Instantiate(playerBothArms);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerBothArmsFirst()
    {
        Player playerClone = Instantiate(playerBothArmsFirst);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerFull()
    {
        Player playerClone = Instantiate(playerFull);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerFullFirst()
    {
        Player playerClone = Instantiate(playerFullFirst);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerLeg()
    {
        Player playerClone = Instantiate(playerLeg);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerLegFirst()
    {
        Player playerClone = Instantiate(playerLegFirst);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerBothLegs()
    {
        Player playerClone = Instantiate(playerBothLegs);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerBothLegsFirst()
    {
        Player playerClone = Instantiate(playerBothLegsFirst);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerBothArmsLeg()
    {
        Player playerClone = Instantiate(playerBothArmsLeg);

        playerClone.gameObject.SetActive(true);
    }

    public void spawnPlayerBothLegsArm()
    {
        Player playerClone = Instantiate(playerBothLegsArm);

        playerClone.gameObject.SetActive(true);
    }

    public void CheckValue()
    {
        switch (Spawner.value)
        {
            case 1:
                spawnPlayer();
                break;

            case 2:
                spawnPlayerSpine();
                break;

            case 3:
                spawnPlayerRibs();
                break;

            case 4:
                spawnPlayerArm();
                break;

            case 5:
                spawnPlayerBothArms();
                break;

            case 6:
                spawnPlayerLeg();
                break;

            case 7:
                spawnPlayerBothLegs();
                break;

            case 8:
                spawnPlayerBothArmsLeg();
                break;

            case 9:
                spawnPlayerBothLegsArm();
                break;

            case 10:
                spawnPlayerFull();
                break;

        }
    }


}
