using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class handleButton : MonoBehaviour
{
    public InputField thetextField;
    public Player player;

    public void buttonBehavior()
  {
        //string userID = thetextField.text.ToString();
        //PlayerPrefs.SetString("Name", userID);
        SceneManager.LoadScene("SampleScene");
  }

    public void button()
    {
        //string userID = thetextField.text.ToString();
        //PlayerPrefs.SetString("Name", userID);
        SceneManager.LoadScene("Room 5");
    }

    public void buttonn()
    {
        //string userID = thetextField.text.ToString();
        //PlayerPrefs.SetString("Name", userID);
        SceneManager.LoadScene("Room 10");
    }

    public void MovePlayer()
    {
        player.setPositionVent1();
    }

    public void MovePlayer2()
    {
        player.setPositionVent2();
    }
}
