using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SgtDayFour : MonoBehaviour
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
        if (gm.newspaperFour == true || gm.pmSkir == true)
        {
            mystery1.gameObject.SetActive(false);
            button1.gameObject.SetActive(true);
        }

        if (gm.hasDocument == true)
        {
            mystery2.gameObject.SetActive(false);
            button2.gameObject.SetActive(true);
        }

        if (gm.sergeantPhone == true)
        {
            mystery3.gameObject.SetActive(false);
            button3.gameObject.SetActive(true);
        }
    }
}
