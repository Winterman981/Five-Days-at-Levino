using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject pauseUI;

    public static PauseMenu instance;
    // Update is called once per frame

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
		{
            if (GamePaused)
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
        pauseUI.SetActive(false);
        Time.timeScale = 1;
        GamePaused = false;
    }

    void Pause()
	{
        pauseUI.SetActive(true);
        Time.timeScale = 0;
        GamePaused = true;
	}

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Retry()
	{
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
	{
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
