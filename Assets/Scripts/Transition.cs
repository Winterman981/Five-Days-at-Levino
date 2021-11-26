using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
	public GameManager gm;

	private void Start()
	{
		GameObject g = GameObject.FindGameObjectWithTag("GameController");

		gm = g.GetComponent<GameManager>();
	}

	public void EndDay()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	//void Update()
	//{
	//	if (Input.GetKeyDown(KeyCode.T))
	//	{
	//		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	//	}
	//}

	public void DayThreeEnd()
	{
		SceneManager.LoadScene(11);
	}

	public void DayFourEnd()
	{
		SceneManager.LoadScene(15);
	}

	public void DayThree()
	{
		if(gm.uniExposure > gm.milExposure && gm.uniExposure > gm.govExposure)
		{
			if(gm.govExposure > gm.milExposure)
			{
				SceneManager.LoadScene(5);
				gm.MDeath = true;
			}

			if (gm.govExposure < gm.milExposure || gm.govExposure == gm.milExposure)
			{
				SceneManager.LoadScene(6);
				gm.GDeath = true;
			}
		}

		if (gm.milExposure > gm.uniExposure && gm.milExposure > gm.govExposure)
		{
			if (gm.uniExposure > gm.govExposure)
			{
				SceneManager.LoadScene(8);
				gm.GDeath = true;
			}

			if (gm.uniExposure < gm.govExposure || gm.uniExposure == gm.govExposure)
			{
				SceneManager.LoadScene(7);
				gm.UDeath = true;
			}
		}

		if (gm.govExposure > gm.milExposure && gm.govExposure > gm.uniExposure)
		{
			if (gm.milExposure > gm.uniExposure || gm.milExposure == gm.uniExposure)
			{
				SceneManager.LoadScene(9);
				gm.UDeath = true;
			}

			if (gm.milExposure < gm.uniExposure)
			{
				SceneManager.LoadScene(10);
				gm.MDeath = true;
			}
		}

		if((gm.govExposure == gm.milExposure) && (gm.milExposure == gm.uniExposure))
		{
			SceneManager.LoadScene(8);
			gm.GDeath = true;
		}

		if((gm.uniExposure == gm.milExposure) && (gm.govExposure < gm.uniExposure) && (gm.govExposure < gm.milExposure))
		{
			SceneManager.LoadScene(8);
			gm.GDeath = true;
		}

		if ((gm.milExposure == gm.govExposure) && (gm.uniExposure < gm.govExposure) && (gm.uniExposure < gm.milExposure))
		{
			SceneManager.LoadScene(7);
			gm.GDeath = true;
		}

		if ((gm.uniExposure == gm.govExposure) && (gm.milExposure < gm.govExposure) && (gm.milExposure < gm.uniExposure))
		{
			SceneManager.LoadScene(10);
			gm.GDeath = true;
		}
	}

	public void DayFour()
	{
		if(gm.UDeath == true)
		{
			SceneManager.LoadScene(14);
		}

		if (gm.MDeath == true)
		{
			SceneManager.LoadScene(12);
		}

		if (gm.GDeath == true)
		{
			SceneManager.LoadScene(13);
		}
	}

	public void DayFive()
	{
		FindObjectOfType<AudioManager>().Stop("BGM");
		if (gm.UDeath == true)
		{
			if (gm.milExposure > gm.govExposure || gm.milExposure == gm.govExposure)
			{
				FindObjectOfType<AudioManager>().Play("Frei");
				SceneManager.LoadScene(19);
			}

			if(gm.milExposure < gm.govExposure)
			{
				FindObjectOfType<AudioManager>().Play("Serve");
				SceneManager.LoadScene(16);
			}
		}

		if (gm.MDeath == true)
		{
			if (gm.uniExposure > gm.govExposure)
			{
				FindObjectOfType<AudioManager>().Play("Internat");
				SceneManager.LoadScene(20);
			}

			if (gm.uniExposure < gm.govExposure || gm.uniExposure == gm.govExposure)
			{
				FindObjectOfType<AudioManager>().Play("Serve");
				SceneManager.LoadScene(17);
			}
		}

		if (gm.GDeath == true)
		{
			if (gm.uniExposure > gm.milExposure)
			{
				FindObjectOfType<AudioManager>().Play("Internat");
				SceneManager.LoadScene(21);
			}

			if (gm.uniExposure < gm.milExposure || gm.uniExposure == gm.milExposure)
			{
				FindObjectOfType<AudioManager>().Play("Frei");
				SceneManager.LoadScene(18);
			}
		}
	}

	public void GovWins()
	{
		SceneManager.LoadScene(24);
	}

	public void UniWins()
	{
		SceneManager.LoadScene(22);
	}

	public void MilWins()
	{
		SceneManager.LoadScene(23);
	}

	public void Menu()
	{
		FindObjectOfType<AudioManager>().Stop("Internat");
		FindObjectOfType<AudioManager>().Stop("Serve");
		FindObjectOfType<AudioManager>().Stop("Frei");
		FindObjectOfType<AudioManager>().Play("BGM");
		SceneManager.LoadScene(0);
	}
}
