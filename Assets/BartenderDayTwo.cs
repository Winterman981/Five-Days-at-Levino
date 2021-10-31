using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BartenderDayTwo : MonoBehaviour
{
    public GameManager gm;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject canvas;

    public GameObject mystery1;
    public GameObject mystery2;
    public GameObject mystery3;
    public GameObject mystery4;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");

        gm = g.GetComponent<GameManager>();

        canvas.gameObject.SetActive(false);

        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);

        mystery1.gameObject.SetActive(false);
        mystery2.gameObject.SetActive(false);
        mystery3.gameObject.SetActive(false);
        mystery4.gameObject.SetActive(false);
    }

    private void Update()
    {
        PouchCheck();
    }

    void PouchCheck()
    {
        if(gm.givenPouch == true)
        {
            mystery1.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(true);
            mystery3.gameObject.SetActive(true);
            mystery4.gameObject.SetActive(true);

            if (gm.seenArrestedUni == true)
            {
                mystery1.gameObject.SetActive(false);
                button1.gameObject.SetActive(true);
            }

            if (gm.seenArrestedSoldier == true)
            {
                mystery2.gameObject.SetActive(false);
                button2.gameObject.SetActive(true);
            }

            if (gm.watchedTVTwo == true)
            {
                mystery3.gameObject.SetActive(false);
                button3.gameObject.SetActive(true);
            }

            if (gm.hasDocument == true)
            {
                mystery4.gameObject.SetActive(false);
                button4.gameObject.SetActive(true);
            }
        }

        else
        {
            canvas.gameObject.SetActive(false);
        }
    }
}
