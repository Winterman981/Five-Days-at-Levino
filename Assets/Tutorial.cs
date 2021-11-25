using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;

	public void Start()
	{
		StartCoroutine(Teach());
	}

	IEnumerator Teach()
	{
		yield return new WaitForSeconds(8);
		text1.gameObject.SetActive(false);
		text2.gameObject.SetActive(true);
		yield return new WaitForSeconds(8);
		text2.gameObject.SetActive(false);
		text3.gameObject.SetActive(true);
		yield return new WaitForSeconds(8);
		text3.gameObject.SetActive(false);
		this.gameObject.SetActive(false);
	}
}
