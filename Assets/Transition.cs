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
		SceneManager.LoadScene(10);
	}

	public void DayFourEnd()
	{
		SceneManager.LoadScene(14);
	}

	public void DayThree()
	{
		if(gm.uniExposure > gm.milExposure && gm.uniExposure > gm.govExposure)
		{
			if(gm.govExposure > gm.milExposure)
			{
				SceneManager.LoadScene(4);
				gm.MDeath = true;
			}

			if (gm.govExposure < gm.milExposure || gm.govExposure == gm.milExposure)
			{
				SceneManager.LoadScene(5);
				gm.GDeath = true;
			}
		}

		if (gm.milExposure > gm.uniExposure && gm.milExposure > gm.govExposure)
		{
			if (gm.uniExposure > gm.govExposure)
			{
				SceneManager.LoadScene(7);
				gm.GDeath = true;
			}

			if (gm.uniExposure < gm.govExposure || gm.uniExposure == gm.govExposure)
			{
				SceneManager.LoadScene(6);
				gm.UDeath = true;
			}
		}

		if (gm.govExposure > gm.milExposure && gm.govExposure > gm.uniExposure)
		{
			if (gm.milExposure > gm.uniExposure || gm.milExposure == gm.uniExposure)
			{
				SceneManager.LoadScene(8);
				gm.UDeath = true;
			}

			if (gm.milExposure < gm.uniExposure)
			{
				SceneManager.LoadScene(9);
				gm.MDeath = true;
			}
		}

		if((gm.govExposure == gm.milExposure) && (gm.milExposure == gm.uniExposure))
		{
			SceneManager.LoadScene(7);
			gm.GDeath = true;
		}
	}

	public void DayFour()
	{
		if(gm.UDeath == true)
		{
			SceneManager.LoadScene(13);
		}

		if (gm.MDeath == true)
		{
			SceneManager.LoadScene(11);
		}

		if (gm.GDeath == true)
		{
			SceneManager.LoadScene(12);
		}
	}
}
