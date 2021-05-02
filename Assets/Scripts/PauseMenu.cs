using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pauseMenuUi;
    public GameObject pausebutton;
    public GameObject soundMenu;
    bool isSound = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        pausebutton.SetActive(true);
        Time.timeScale = 1f;
        GameisPaused = false;
        soundMenu.SetActive(false);
    }

    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        pausebutton.SetActive(false);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void SoundMenu()
    {
        if(isSound == false)
        {
            soundMenu.SetActive(true);
            isSound = true;
        }
        else
        {
            soundMenu.SetActive(false);
            isSound = false;
        }
        

    }
}
