using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BartenderDayFour : MonoBehaviour
{
    public GameManager gm;

    public GameObject button1;

    public GameObject mystery1;


    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");

        gm = g.GetComponent<GameManager>();

        button1.gameObject.SetActive(false);
    }

    private void Update()
    {
        MysteryCheck();
    }

    void MysteryCheck()
    {
        if (gm.militaryViolence == true || gm.pmSkir == true)
        {
            mystery1.gameObject.SetActive(false);
            button1.gameObject.SetActive(true);
        }
    }
}
