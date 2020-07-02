using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Level 1"); //load lvl 1
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level 2"); //load lvl 2
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level 3"); //load lvl 3
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level 4"); //load lvl 4
    }

    public void back()
    {
        SceneManager.LoadScene("Main Menu"); //load main menu
    }
}
