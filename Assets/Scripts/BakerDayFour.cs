using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakerDayFour : MonoBehaviour
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
        if (gm.newspaperFour == true || gm.militaryViolence == true)
        {
            mystery1.gameObject.SetActive(false);
            button1.gameObject.SetActive(true);
        }
    }
}
