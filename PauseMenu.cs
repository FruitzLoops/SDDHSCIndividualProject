using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject PaueMenuUI;

    void Start()
    {
        PaueMenuUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (gamePaused)
            {
                Resume();
            } else
            {
                Pause();
            }

        }
    }

    public void Resume()
    {
        PaueMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }


    void Pause()
    {
        PaueMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
