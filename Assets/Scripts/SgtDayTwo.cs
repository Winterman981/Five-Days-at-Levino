using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SgtDayTwo : MonoBehaviour
{
    public GameManager gm;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    public GameObject mystery1;
    public GameObject mystery2;
    public GameObject mystery3;
    public GameObject mystery4;

    public GameObject corruption;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");

        gm = g.GetComponent<GameManager>();

        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);

        corruption.gameObject.SetActive(false);
    }

    private void Update()
    {
        MysteryCheck();
    }

    void MysteryCheck()
    {
        if (gm.watchedTVTwo == true)
        {
            mystery1.gameObject.SetActive(false);
            button1.gameObject.SetActive(true);
        }

        if (gm.seenArrestedUni == true)
        {
            mystery2.gameObject.SetActive(false);
            button2.gameObject.SetActive(true);
        }

        if (gm.seenArrestedSoldier == true)
        {
            mystery3.gameObject.SetActive(false);
            button3.gameObject.SetActive(true);
        }

        if (gm.sergeantPromise == true)
        {
            mystery4.gameObject.SetActive(false);
            button4.gameObject.SetActive(true);
        }

        if(gm.sgtUnionComment == true && gm.hasDocument == true)
		{
            corruption.gameObject.SetActive(true);
		}
    }
}
