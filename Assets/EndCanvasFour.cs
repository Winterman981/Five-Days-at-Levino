using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCanvasFour : MonoBehaviour
{
    public GameManager gm;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button10;
    public GameObject button11;
    public GameObject button12;

    public GameObject mystery1;
    public GameObject mystery2;
    public GameObject mystery3;
    public GameObject mystery4;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        gm = g.GetComponent<GameManager>();

        GameCheck();
        ModCheck();

    }

    public void Update()
    {

    }

    public void GameCheck()
    {
        if (gm.corruptionPlea == true)
        {
            button1.gameObject.SetActive(true);
            mystery1.gameObject.SetActive(false);
        }

        if (gm.truceDoc == true)
        {
            button2.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);
        }

        if (gm.sgtCommentFour == true)
        {
            button3.gameObject.SetActive(true);
            mystery3.gameObject.SetActive(false);
        }

        if (gm.newspaperFour == true)
        {
            button4.gameObject.SetActive(true);
            mystery4.gameObject.SetActive(false);
        }

        if (gm.militaryViolence == true)
        {
            button5.gameObject.SetActive(true);
            mystery1.gameObject.SetActive(false);
        }

        if (gm.soldierDayFour == true)
        {
            button6.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);
        }

        if (gm.ptsdBaker == true)
        {
            button7.gameObject.SetActive(true);
            mystery3.gameObject.SetActive(false);
        }

        if (gm.militia == true)
        {
            button8.gameObject.SetActive(true);
            mystery4.gameObject.SetActive(false);
        }

        if (gm.milDoc == true)
        {
            button9.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);
        }

        if (gm.pmSkir == true)
        {
            button10.gameObject.SetActive(true);
            mystery3.gameObject.SetActive(false);
        }

        if (gm.soldierDayFourG == true)
        {
            button11.gameObject.SetActive(true);
            mystery4.gameObject.SetActive(false);
        }
    }

    public void ModCheck()
    {
        if (gm.newspaperFour == true && gm.bakerNewsFour == true)
        {
            button4.gameObject.SetActive(false);
            button12.gameObject.SetActive(true);
        }
    }

    public void CorruptionPlea()
    {
        gm.ModifyGov(1);
        Destroy(button1);
    }

    public void TruceDocument()
    {
        gm.ModifyGov(3);
        gm.ModifyUni(-3);
        Destroy(button2);
    }

    public void SgtComment()
    {
        gm.ModifyGov(1);
        gm.ModifyUni(-2);
        Destroy(button3);
    }

    public void NewspaperFour()
    {
        gm.ModifyGov(-3);
        gm.ModifyUni(1);
        Destroy(button4);
    }

    public void NewspaperMod()
    {
        gm.ModifyGov(-4);
        gm.ModifyUni(2);
        Destroy(button12);
    }

    public void MilCrackdown()
    {
        gm.ModifyMil(-3);
        Destroy(button5);
    }

    public void SoldierU()
    {
        gm.ModifyUni(-2);
        Destroy(button6);
    }

    public void PTSD()
    {
        gm.ModifyMil(-3);
        Destroy(button7);
    }

    public void Militia()
    {
        gm.ModifyUni(3);
        Destroy(button8);
    }

    public void MilDocument()
    {
        gm.ModifyMil(-4);
        gm.ModifyGov(4);
        Destroy(button9);
    }

    public void Skirmish()
    {
        gm.ModifyMil(1);
        gm.ModifyGov(-2);
        Destroy(button10);
    }

    public void SoldierG()
    {
        gm.ModifyGov(-2);
        Destroy(button11);
    }
}
