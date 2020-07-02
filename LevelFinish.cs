using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{

    public GameObject lvlFinishUI;
    // Start is called before the first frame update
    void Start()
    {
        lvlFinishUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enddoor.lvlFin)
        {
            lvlFinished();
        }
    }

    private void lvlFinished()
    {
        Time.timeScale = 0f; //time stops
        lvlFinishUI.SetActive(true); //display level finished screen
    }

    public void Retry()
    {
        Time.timeScale = 1f; //time starts
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reload scene
        lvlFinishUI.SetActive(false);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f; //time starts
        SceneManager.LoadScene("Main Menu"); //load main menu
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //next level
    }
}
