using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverMenuUI;
 

    void Start()
    {
        GameOverMenuUI.SetActive(false);
        Global.playerDead = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.playerDead)
        {
            GameOverr();
        }
    }

    void GameOverr()
    {
        Time.timeScale = 0f; //stop time
        GameOverMenuUI.SetActive(true); //display game over screen
    }

    public void Retry()
    {
        Time.timeScale = 1f; //start time
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reload level
        GameOverMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f; //start time
        SceneManager.LoadScene("Main Menu"); //load main menu
    }

 
}
