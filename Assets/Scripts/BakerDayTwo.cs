using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakerDayTwo : MonoBehaviour
{
    public GameManager gm;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public GameObject mystery1;
    public GameObject mystery2;
    public GameObject mystery3;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");

        gm = g.GetComponent<GameManager>();

        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
    }

    private void Update()
    {
        MysteryCheck();
    }

    void MysteryCheck()
    {
        if(gm.seenArrestedUni == true)
        {
            mystery1.gameObject.SetActive(false);
            button1.gameObject.SetActive(true);
        }

        if (gm.hasBooklet == true && gm.seenArrestedSoldier == true)
        {
            mystery2.gameObject.SetActive(false);
            button2.gameObject.SetActive(true);
        }

        if (gm.watchedTVTwo == true)
        {
            mystery3.gameObject.SetActive(false);
            button3.gameObject.SetActive(true);
        }
    }
}
