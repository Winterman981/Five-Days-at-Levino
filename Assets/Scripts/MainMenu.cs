using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Intro()
    {
        SceneManager.LoadScene(25);
    }

    public void DayOne()
	{
        SceneManager.LoadScene(1);
    }

    public void SceneSelect()
	{
        SceneManager.LoadScene(26);
    }
}
