using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
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
}
