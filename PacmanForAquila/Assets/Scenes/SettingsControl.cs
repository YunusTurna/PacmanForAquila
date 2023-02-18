using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class SettingsControl : MonoBehaviour
{
    public static bool isGamePaused;
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    public GameObject panel;
    public AudioSource theme;
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(isGamePaused)
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
        pauseMenu.SetActive(false);
        panel.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        panel.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }
    public void Loadscene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Options()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
        isGamePaused=true;
    }
    public void Fullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }
    public void Music(bool isMusic)
    {
        theme.mute = !isMusic;
    }
}
