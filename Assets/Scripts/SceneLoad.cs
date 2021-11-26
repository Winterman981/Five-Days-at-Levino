using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
	public int number;
	public GameManager gm;
    public void LoadScene(int sceneNumber)
	{
		number = sceneNumber;
		SceneManager.LoadScene(sceneNumber);

		if(sceneNumber == 7 || sceneNumber == 9 || sceneNumber == 14)
		{
			gm.UDeath = true;
			SceneManager.LoadScene(sceneNumber);
		}

		if (sceneNumber == 5 || sceneNumber == 10 || sceneNumber == 12)
		{
			gm.MDeath = true;
			SceneManager.LoadScene(sceneNumber);
		}

		if (sceneNumber == 6 || sceneNumber == 8 || sceneNumber == 13)
		{
			gm.GDeath = true;
			SceneManager.LoadScene(sceneNumber);
		}

		if (sceneNumber == 16 || sceneNumber == 17)
		{
			FindObjectOfType<AudioManager>().Stop("BGM");
			FindObjectOfType<AudioManager>().Play("Serve");
			SceneManager.LoadScene(sceneNumber);
		}

		if (sceneNumber == 20 || sceneNumber == 21)
		{
			FindObjectOfType<AudioManager>().Stop("BGM");
			FindObjectOfType<AudioManager>().Play("Internat");
			SceneManager.LoadScene(sceneNumber);
		}

		if (sceneNumber == 18 || sceneNumber == 19)
		{
			FindObjectOfType<AudioManager>().Stop("BGM");
			FindObjectOfType<AudioManager>().Play("Frei");
			SceneManager.LoadScene(sceneNumber);
		}
	}
}
